using System.ComponentModel.DataAnnotations;

namespace AFX.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}