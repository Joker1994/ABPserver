using System.ComponentModel.DataAnnotations;

namespace siasun.MCS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}