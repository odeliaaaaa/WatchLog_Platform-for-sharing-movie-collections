using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mvc_WatchLog.Data;
using Mvc_WatchLog.Models;

namespace Mvc_WatchLog.Controllers
{
    [Authorize]
    public class WatchRecordController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public WatchRecordController(
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> SearchTMDBMedia(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return BadRequest("請輸入作品名稱");
            }

            var apiKey = _configuration["TMDB:ApiKey"];

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                return StatusCode(500, "TMDB API Key 尚未設定");
            }

            using var client = new HttpClient();

            var url =
                $"https://api.themoviedb.org/3/search/multi" +
                $"?api_key={apiKey}" +
                $"&language=zh-TW" +
                $"&query={Uri.EscapeDataString(term)}";

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode(502, "TMDB 搜尋失敗");
            }

            var json = await response.Content.ReadAsStringAsync();

            return Content(json, "application/json");
        }

        public IActionResult Create()
        {
            ViewBag.MediaList = new SelectList(_context.Media, "MediaId", "Title");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(WatchRecord watchRecord, string NewMediaTitle)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            watchRecord.UserId = currentUser.Id;

            if (!string.IsNullOrWhiteSpace(NewMediaTitle))
            {
                var media = await _context.Media.FirstOrDefaultAsync(m => m.Title == NewMediaTitle);

                if (media == null)
                {
                    string posterUrl = null;
                    string apiKey = _configuration["TMDB:ApiKey"];

                    try
                    {
                        using (var client = new HttpClient())
                        {
                            var url = $"https://api.themoviedb.org/3/search/multi?api_key={apiKey}&language=zh-TW&query={Uri.EscapeDataString(NewMediaTitle)}";
                            var response = await client.GetAsync(url);

                            if (response.IsSuccessStatusCode)
                            {
                                var jsonResponse = await response.Content.ReadAsStringAsync();
                                var pathStart = jsonResponse.IndexOf("\"poster_path\":\"");
                                if (pathStart != -1)
                                {
                                    pathStart += 15;
                                    var pathEnd = jsonResponse.IndexOf("\"", pathStart);
                                    var posterPath = jsonResponse.Substring(pathStart, pathEnd - pathStart);

                                    if (!string.IsNullOrEmpty(posterPath) && posterPath != "null")
                                    {
                                        posterUrl = $"https://image.tmdb.org/t/p/w500{posterPath}";
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                    }

                    media = new Media
                    {
                        Title = NewMediaTitle,
                        Genre = "未分類",
                        Type = "未知",
                        PosterUrl = posterUrl
                    };
                    _context.Media.Add(media);
                    await _context.SaveChangesAsync();
                }

                watchRecord.MediaId = media.MediaId;
            }

            bool hasWritten = await _context.WatchRecords
                .AnyAsync(w => w.UserId == currentUser.Id && w.MediaId == watchRecord.MediaId);

            if (hasWritten)
            {
                TempData["SweetAlert"] = "你已經為這部作品寫過日記囉！可以直接在這裡修改它✨";
                return RedirectToAction(nameof(MyDiary));
            }

            ModelState.Remove("UserId");
            ModelState.Remove("User");
            ModelState.Remove("Media");
            ModelState.Remove("MediaId");

            if (ModelState.IsValid)
            {
                watchRecord.CreatedAt = DateTime.Now;
                _context.Add(watchRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyDiary));
            }

            return View(watchRecord);
        }

        [HttpGet]
        public async Task<IActionResult> SearchMedia(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return Json(new List<object>());
            }

            var results = await _context.Media
                .Where(m => m.Title.Contains(term))
                .Select(m => new { id = m.MediaId, title = m.Title })
                .Take(10)
                .ToListAsync();

            return Json(results);
        }

        [Authorize]
        public async Task<IActionResult> MyDiary()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var myRecords = await _context.WatchRecords
                .Include(w => w.Media)
                .Include(w => w.Favorites) // 讓專屬放映室也能看到讚數
                .Where(w => w.UserId == currentUser.Id)
                .OrderByDescending(w => w.RecordId)
                .ToListAsync();

            return View(myRecords);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var currentUser = await _userManager.GetUserAsync(User);

            var watchRecord = await _context.WatchRecords
                .Include(w => w.Media)
                .FirstOrDefaultAsync(w => w.RecordId == id && w.UserId == currentUser.Id);

            if (watchRecord == null) return NotFound();

            return View(watchRecord);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, WatchRecord watchRecord)
        {
            if (id != watchRecord.RecordId) return NotFound();

            var currentUser = await _userManager.GetUserAsync(User);

            var existingRecord = await _context.WatchRecords.AsNoTracking().FirstOrDefaultAsync(w => w.RecordId == id && w.UserId == currentUser.Id);
            if (existingRecord == null) return NotFound();

            watchRecord.UserId = currentUser.Id;

            ModelState.Remove("UserId");
            ModelState.Remove("User");
            ModelState.Remove("Media");

            if (ModelState.IsValid)
            {
                _context.Update(watchRecord);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(MyDiary));
            }

            return View(watchRecord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var watchRecord = await _context.WatchRecords
                .FirstOrDefaultAsync(w => w.RecordId == id && w.UserId == currentUser.Id);

            if (watchRecord != null)
            {
                _context.WatchRecords.Remove(watchRecord);
                await _context.SaveChangesAsync();

                TempData["SweetAlert"] = "那段記憶已經成功被清除了！🗑️";
            }

            return RedirectToAction(nameof(MyDiary));
        }

        // ==========================================
        // 🌟 新增：顯示登入者的「我的收藏片單」
        // ==========================================
        [Authorize]
        public async Task<IActionResult> MyFavorites()
        {
            var userId = _userManager.GetUserId(User);

            var favoriteRecords = await _context.WatchRecords
                .Include(w => w.Media)
                .Include(w => w.User)
                .Include(w => w.Favorites)
                .Where(w => w.Favorites.Any(f => f.UserId == userId))
                .OrderByDescending(w => w.RecordId)
                .ToListAsync();

            return View(favoriteRecords);
        }
    }
}