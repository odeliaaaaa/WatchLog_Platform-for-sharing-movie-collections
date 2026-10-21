using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_WatchLog.Data;
using Mvc_WatchLog.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace Mvc_WatchLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // ==============================
        // 首頁：小紅書動態牆 ＋ 劇名評價篩選器 ＋ 分頁功能
        // ==============================
        // 👇 參數多加了一個 int page = 1，代表預設是在第 1 頁
        public async Task<IActionResult> Index(string searchString, int page = 1)
        {
            int pageSize = 9; // 💡 規定一頁顯示幾筆 (可自行修改)

            var query = _context.WatchRecords
                .Include(w => w.Media)
                .Include(w => w.User)
                .Include(w => w.Favorites)
                .Where(w => w.IsPublic)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(w => w.Media.Title.Contains(searchString));
                ViewBag.SearchString = searchString;
            }

            // 🌟 1. 計算總共有幾筆公開日記
            int totalItems = await query.CountAsync();

            // 🌟 2. 計算總共需要幾頁 (無條件進位)
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // 🌟 3. 抓取「當前頁數」的資料 (Skip 跳過前面的，Take 抓取現在這頁的)
            var recentReviews = await query
                .OrderByDescending(w => w.CreatedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // 🌟 4. 把分頁資訊打包，準備傳給網頁前端
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(recentReviews);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // ==============================
        // 🌟 新增：處理 AJAX 按讚邏輯
        // ==============================
        [HttpPost]
        public async Task<IActionResult> ToggleLike(int recordId)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Json(new { success = false, message = "請先登入才能按讚喔！" });
            }

            // 🌟 修正：原本是 FavoriteId，要改成 RecordId 才能對應妳的資料表
            var existingLike = await _context.Favorites
                .FirstOrDefaultAsync(f => f.RecordId == recordId && f.UserId == userId);

            bool isLiked = false;

            if (existingLike != null)
            {
                _context.Favorites.Remove(existingLike);
            }
            else
            {
                // 🌟 修正：改成 RecordId = recordId
                _context.Favorites.Add(new Favorite { RecordId = recordId, UserId = userId });
                isLiked = true;
            }
            await _context.SaveChangesAsync();

            // 🌟 修正：改成 RecordId == recordId
            var likeCount = await _context.Favorites.CountAsync(f => f.RecordId == recordId);

            return Json(new { success = true, isLiked = isLiked, count = likeCount });
        }
    }
}