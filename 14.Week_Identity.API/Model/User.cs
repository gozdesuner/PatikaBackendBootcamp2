using System.ComponentModel.DataAnnotations;

namespace _14.Week_Identity.API.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi giriniz.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(8, ErrorMessage = "Şifren en az 9 karakter olmalıdır.")]
        public string Password { get; set; } = "";

    }
}
