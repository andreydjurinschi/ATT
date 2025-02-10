using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using TeachSyncAppAT.Models;

namespace TeachSyncAppAT.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
