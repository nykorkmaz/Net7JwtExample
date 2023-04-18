using System.ComponentModel.DataAnnotations;

namespace Net7JwtExample.Data
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı gerekli")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Şifre gerekli")]
        public string? Password { get; set; }
    }
}
