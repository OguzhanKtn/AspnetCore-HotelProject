using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı adınızı giriniz.")]
        public string UserName { get; set;}

        [Required(ErrorMessage = "Parolanızı giriniz.")]
        public string Password { get; set;}
    }
}
