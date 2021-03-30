using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;

namespace siasun.MCS.Models.TokenAuth
{
    public class AuthenticateModel
    {
        //[Required]
        //[StringLength(AbpUserBase.MaxEmailAddressLength)]
        //public string UserNameOrEmailAddress { get; set; }

        //[Required]
        //[StringLength(AbpUserBase.MaxPlainPasswordLength)]
        //[DisableAuditing]
        //public string Password { get; set; }

        //public bool RememberClient { get; set; }

        public bool autoLogin { get; set; }
        /// <summary>
        /// 控制对象
        /// </summary>
        public string type { get; set; }


        [Required]
        [MaxLength(AbpUserBase.MaxEmailAddressLength)]
        public string userName { get; set; }

        [Required]
        [MaxLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string password { get; set; }

        public string TwoFactorVerificationCode { get; set; }

        public bool RememberClient { get; set; }

        public string TwoFactorRememberClientToken { get; set; }

        public bool? SingleSignIn { get; set; }

        public string ReturnUrl { get; set; }
    }
}
