using System.ComponentModel.DataAnnotations;

namespace NutNull.DemoProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}