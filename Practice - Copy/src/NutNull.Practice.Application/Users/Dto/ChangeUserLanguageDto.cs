using System.ComponentModel.DataAnnotations;

namespace NutNull.Practice.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}