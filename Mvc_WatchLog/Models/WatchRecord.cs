using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_WatchLog.Models
{
    public class WatchRecord
    {
        [Key]
        public int RecordId { get; set; } // record_id [cite: 85]

        [Required]
        public string UserId { get; set; } // 改為 string 以對應 IdentityUser

        [Required]
        public int MediaId { get; set; } // media_id [cite: 87]

        public bool Watched { get; set; } // watched [cite: 88]

        // 依據你的系統分析，評分機制為 1～5 分
        [Range(1, 5, ErrorMessage = "評分必須在 1 到 5 分之間")]
        public int? Rating { get; set; } // rating [cite: 89]

        public string Review { get; set; } // review [cite: 90]

        [Required]
        public bool IsPublic { get; set; } = true;

        // 當類型為 movie 時 episode 可為 NULL
        public int? Episode { get; set; } // episode [cite: 91]

        // 👇 新增這個紀錄時間的欄位，並預設為當下時間
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // 找個適合的地方（例如 IsPublic 下方）加上這行：
        public bool ShowPoster { get; set; } = true; // 預設為 true (顯示海報)

        // 記錄是否包含劇透 (預設為 false)
        public bool HasSpoiler { get; set; } = false;
        // 設定外鍵關聯
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        [ForeignKey("MediaId")]
        public Media Media { get; set; }

        // 關聯：這篇日記擁有哪些讚 (請確保名字拼字一模一樣是 Favorites)
        public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }

}