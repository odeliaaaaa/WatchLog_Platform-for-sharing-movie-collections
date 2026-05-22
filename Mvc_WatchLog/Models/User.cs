using System.ComponentModel.DataAnnotations;

namespace Mvc_WatchLog.Models
{
    public class User
    {
        public int user_Id { get; set; }

        [Required(ErrorMessage ="請輸入使用者名稱")]
        public string name { get; set; }

        [Required(ErrorMessage ="請輸入密碼")]
        public string password { get; set; }
    }
}
