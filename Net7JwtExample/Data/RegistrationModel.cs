using System.ComponentModel.DataAnnotations;

namespace Net7JwtExample.Data
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı gerekli")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Ad gerekli")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad gerekli")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email gerekli")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre gerekli")]
        public string Password { get; set; }
    }
}
