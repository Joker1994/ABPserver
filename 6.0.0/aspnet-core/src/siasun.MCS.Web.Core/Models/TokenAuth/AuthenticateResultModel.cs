using System.Collections.Generic;

namespace siasun.MCS.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        //public string AccessToken { get; set; }

        //public string EncryptedAccessToken { get; set; }

        //public int ExpireInSeconds { get; set; }

        //public long UserId { get; set; }

        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public bool ShouldResetPassword { get; set; }

        public string PasswordResetCode { get; set; }

        public long UserId { get; set; }

        public bool RequiresTwoFactorVerification { get; set; }

        public IList<string> TwoFactorAuthProviders { get; set; }

        public string TwoFactorRememberClientToken { get; set; }

        public string ReturnUrl { get; set; }

        public string status { get; set; }
    }
}
