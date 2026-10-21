using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc_WatchLog.Models
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; } // media_id [cite: 78]

        [Required]
        [StringLength(255)]
        public string Title { get; set; } // title [cite: 79]

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // movie / series [cite: 80]

        [StringLength(100)]
        public string Genre { get; set; } // genre [cite: 81]
        [StringLength(500)]
        public string? PosterUrl { get; set; }

        // 關聯導覽屬性
        public ICollection<WatchRecord>? WatchRecords { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }
    }
}