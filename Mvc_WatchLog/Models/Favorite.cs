using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_WatchLog.Models
{
    public class Favorite
    {
        [Key]
        public int FavoriteId { get; set; } // 🌟 關鍵：改回原本的名字，不惹 SQL Server 生氣

        public string UserId { get; set; }

        public int RecordId { get; set; } // 這是我們要順利加進去的新欄位

        [ForeignKey("RecordId")]
        public virtual WatchRecord WatchRecord { get; set; }
    }
}