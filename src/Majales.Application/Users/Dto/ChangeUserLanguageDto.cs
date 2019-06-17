using System.ComponentModel.DataAnnotations;

namespace Majales.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}