using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mvc_WatchLog.Models;

namespace Mvc_WatchLog.Data
{
    // 繼承 IdentityDbContext，它會自動幫我們處理 Users 表格
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 將你的資料表註冊進來
        public DbSet<Media> Media { get; set; }
        public DbSet<WatchRecord> WatchRecords { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        // 👇 攔截資料庫建立的瞬間，施展「前後綴全包」改名魔法
        // 👇 攔截資料庫建立的瞬間，施展「無底線前後綴」改名魔法
        // 👇 攔截資料庫建立的瞬間，施展「極致淨化」改名魔法
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // ⚠️ 這一行絕對不能刪掉，它是 ASP.NET Core Identity 能夠正常運作的基石！
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var originalTableName = entityType.GetTableName();

                if (!string.IsNullOrEmpty(originalTableName))
                {
                    // 把之前可能加上的前綴、後綴，還有系統內建的 "AspNet" 全部洗掉！
                    var cleanName = originalTableName
                        .Replace("Table_", "")
                        .Replace("Table", "")
                        .Replace("_s1131601", "")
                        .Replace("s1131601", "")
                        .Replace("AspNet", ""); // 👈 拔除多餘的 AspNet

                    // 🌟 重新組合成教授要的最終格式：Table + 原始名稱 + s1131601
                    entityType.SetTableName($"Table{cleanName}s1131601");
                }
            }
        }
    }
}