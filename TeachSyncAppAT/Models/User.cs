using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;

namespace TeachSyncAppAT.Models
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        //public int RoleId { get; set; }
        //public Role Role { get; set; }//навигационное поле
    }
}
