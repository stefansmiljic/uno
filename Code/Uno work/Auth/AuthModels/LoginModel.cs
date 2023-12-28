using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.NET8._0.Auth.AuthModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}