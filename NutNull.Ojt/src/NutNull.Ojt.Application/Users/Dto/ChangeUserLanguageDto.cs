using System.ComponentModel.DataAnnotations;

namespace NutNull.Ojt.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}