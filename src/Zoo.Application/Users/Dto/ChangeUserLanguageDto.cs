using System.ComponentModel.DataAnnotations;

namespace Zoo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}