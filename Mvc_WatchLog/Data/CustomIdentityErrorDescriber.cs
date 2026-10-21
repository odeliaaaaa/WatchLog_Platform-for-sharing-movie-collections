using Microsoft.AspNetCore.Identity;

namespace Mvc_WatchLog.Models // 注意妳的命名空間
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "密碼必須包含至少一個特殊符號（例如：@, #, !, 等）。"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "密碼必須包含至少一個小寫字母 ('a'-'z')。"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "密碼必須包含至少一個大寫字母 ('A'-'Z')。"
            };
        }

        // 如果妳遇到密碼太短的英文錯誤，也可以順便在這裡翻掉
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = $"密碼長度至少必須為 {length} 個字元。"
            };
        }
    }
}