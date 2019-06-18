using System.ComponentModel.DataAnnotations;

namespace SeaBlog.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}