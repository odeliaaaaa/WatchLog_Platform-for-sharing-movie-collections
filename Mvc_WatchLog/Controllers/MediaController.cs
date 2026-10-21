using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mvc_WatchLog.Data;
using Mvc_WatchLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_WatchLog.Controllers
{
    // 🛡️ 告訴系統這個控制器只有登入的人才能進來
    [Authorize]
    public class MediaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MediaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ==========================================
        // 管理員專屬：媒體庫與數據分析儀表板
        // ==========================================
        public async Task<IActionResult> Index()
        {
            // 👑 防護罩：如果不是管理員信箱，直接把他踹回首頁！
            // ⚠️ 記得把下面的 admin@test.com 換成妳真正要用的管理員信箱喔！
            if (User.Identity?.Name != "admin@test.com")
            {
                return RedirectToAction("Index", "Home");
            }

            // 1. 抓出所有的媒體庫清單
            var mediaList = await _context.Media.ToListAsync();

            // 2. 數據分析 A：計算「公開」與「私人」的日記數量 (圓餅圖)
            ViewBag.PublicCount = await _context.WatchRecords.CountAsync(w => w.IsPublic);
            ViewBag.PrivateCount = await _context.WatchRecords.CountAsync(w => !w.IsPublic);

            // 3. 數據分析 B：找出「被寫過最多次日記」的前 5 名作品 (長條圖)
            var topMedia = await _context.WatchRecords
                .Include(w => w.Media)
                .Where(w => w.Media != null)
                .GroupBy(w => w.Media.Title)
                .Select(g => new { Title = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .Take(5)
                .ToListAsync();

            ViewBag.ChartLabels = topMedia.Select(t => t.Title).ToArray();
            ViewBag.ChartData = topMedia.Select(t => t.Count).ToArray();

            // 4. 數據分析 C：每日新增日記趨勢 (線形圖)
            // 第一步：先讓 SQL Server 幫我們分組計算數量 (這時候先不要用 ToString)
            var rawTrendData = await _context.WatchRecords
                .Where(w => w.CreatedAt != null)
                .GroupBy(w => w.CreatedAt.Date)
                .Select(g => new { Date = g.Key, Count = g.Count() })
                .OrderBy(g => g.Date)
                .Take(7)
                .ToListAsync(); // 執行這行時，資料就從 SQL 抓回 C# 記憶體了！

            // 第二步：在 C# 記憶體裡面，安心地把日期轉換成 "MM/dd" 格式
            var trendData = rawTrendData
                .Select(t => new {
                    Date = t.Date.ToString("MM/dd"),
                    Count = t.Count
                })
                .ToList();

            ViewBag.LineLabels = trendData.Select(t => t.Date).ToArray();
            ViewBag.LineData = trendData.Select(t => t.Count).ToArray();
            return View(mediaList);
        }

        // GET: Media/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var media = await _context.Media.FirstOrDefaultAsync(m => m.MediaId == id);
            if (media == null) return NotFound();
            return View(media);
        }

        // GET: Media/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Media/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MediaId,Title,Type,Genre")] Media media)
        {
            if (ModelState.IsValid)
            {
                _context.Add(media);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(media);
        }

        // GET: Media/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var media = await _context.Media.FindAsync(id);
            if (media == null) return NotFound();
            return View(media);
        }

        // POST: Media/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MediaId,Title,Type,Genre")] Media media)
        {
            if (id != media.MediaId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(media);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MediaExists(media.MediaId)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(media);
        }

        // GET: Media/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var media = await _context.Media.FirstOrDefaultAsync(m => m.MediaId == id);
            if (media == null) return NotFound();
            return View(media);
        }

        // POST: Media/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var media = await _context.Media.FindAsync(id);
            if (media != null) _context.Media.Remove(media);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MediaExists(int id)
        {
            return _context.Media.Any(e => e.MediaId == id);
        }
    }
}