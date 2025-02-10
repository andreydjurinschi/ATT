using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TeachSyncAppAT.Models;

namespace TeachSyncAppAT.Areas.Account.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Entry the name pls")]
        [DisplayName("Name")]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Entry the surname pls")]
        [DisplayName("Surname")]
        public string Surname { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Entry the email pls")]
        [DisplayName("Email")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Entry the login pls")]
        [DisplayName("Login")]
        public string Login { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Entry the password pls")]
        [DisplayName("Password")]
        public string Password { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Entry the password pls")]
        [Compare("Password", ErrorMessage ="Passwords are not the same")]
        [DisplayName("Confirm password")]
        public string PasswordConfirm { get; set; } = string.Empty;

        public User GetUser() 
        {
            return new User 
            {
                Email = Email,
                UserName = Login,
                Name = Name,
                Surname = Surname,

            };
        }

    }
}
