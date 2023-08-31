using System.ComponentModel.DataAnnotations;

namespace AllPawTemplate.Dtos
{
    public class UserLoginModelDto
    {
        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Password { get; set; }
    }
}
