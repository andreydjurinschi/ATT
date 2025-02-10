using System.ComponentModel.DataAnnotations;

namespace TeachSyncAppAT.Areas.Account.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Fill login")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Fill password")]
        public string Password { get; set; } = string.Empty;
    }
}
