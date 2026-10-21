using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_WatchLog.Data;
using System;

namespace Mvc_WatchLog.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        // 👑 記得改成妳的管理員信箱
        private readonly string _adminEmail = "admin@test.com";

        public AdminController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        private bool IsAdmin() => User.Identity?.Name == _adminEmail;

        // ==========================================
        // 1. 查詢 (Read): 顯示所有會員清單 (已加入分頁功能 🌟)
        // ==========================================
        public async Task<IActionResult> Index(string searchEmail, int page = 1)
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");

            int pageSize = 10; // 💡 規定一頁顯示幾筆會員

            // 建立查詢 (先過濾掉管理員自己)
            var query = _userManager.Users.Where(u => u.Email != _adminEmail).AsQueryable();

            // 🔍 如果有輸入搜尋字串，就過濾信箱
            if (!string.IsNullOrEmpty(searchEmail))
            {
                query = query.Where(u => u.Email.Contains(searchEmail));
                ViewBag.SearchEmail = searchEmail;
            }

            // 🌟 分頁計算魔法
            int totalItems = await query.CountAsync();
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // 🌟 取出「當前頁數」的會員名單
            var users = await query
                .OrderBy(u => u.Email) // 依照信箱字母排序，讓名單有固定的順序
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // 🌟 打包分頁資訊給前端
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(users);
        }

        // ==========================================
        // 原有功能：詳細資料
        // ==========================================
        public async Task<IActionResult> Details(string id)
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");

            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var userRecords = await _context.WatchRecords
                .Include(w => w.Media)
                .Where(w => w.UserId == id)
                .OrderByDescending(w => w.CreatedAt)
                .ToListAsync();

            ViewBag.UserRecords = userRecords;
            return View(user);
        }

        // ==========================================
        // 原有功能：刪除會員
        // ==========================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");

            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
                TempData["SweetAlert"] = "該會員已被強制刪除並踢出系統！🚨";
            }
            return RedirectToAction(nameof(Index));
        }

        // ==========================================
        // 原有功能：新增會員
        // ==========================================
        public IActionResult Create()
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string email, string password)
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = email, Email = email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    TempData["SweetAlert"] = "新會員建立成功！🎉";
                    return RedirectToAction(nameof(Index));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }

        // ==========================================
        // 原有功能：修改會員
        // ==========================================
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, string email, string newPassword)
        {
            if (!IsAdmin()) return RedirectToAction("Index", "Home");

            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.Email = email;
            user.UserName = email;
            await _userManager.UpdateAsync(user);

            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passResult = await _userManager.ResetPasswordAsync(user, token, newPassword);

                if (!passResult.Succeeded)
                {
                    foreach (var error in passResult.Errors) ModelState.AddModelError(string.Empty, error.Description);
                    return View(user);
                }
            }

            TempData["SweetAlert"] = "會員資料修改成功！✨";
            return RedirectToAction(nameof(Index));
        }
    }
}