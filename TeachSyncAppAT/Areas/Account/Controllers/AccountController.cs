using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using TeachSyncAppAT.Models;
using TeachSyncAppAT.Areas.Account.Models;

namespace TeachSyncAppAT.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountController : Controller
    {
        private UserManager<User> _userM;
        private SignInManager<User> _userS;

        public AccountController(UserManager<User> userM, SignInManager<User> userS)
        {
            _userM = userM;
            _userS = userS;
        }

        [Route("{area}/{action}")]
        [HttpGet]
        public IActionResult SignIn() 
        {
            return View();
        }

        [Route("{area}/{action}")]
        [HttpPost]
        public async Task<IActionResult> SignIn(Models.LoginModel model) 
        {
            var result = await _userS.PasswordSignInAsync(model.Login, model.Password,false,lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return LocalRedirect("/");
            }
            else 
            {
                ModelState.AddModelError("", "BLABLABLA");
            }
            return View("Login");
        }

        [Route("{area}/{action}")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("{area}/{action}")]
        [HttpPost]
        public async Task<IActionResult> Register(Models.RegisterModel model) 
        {
            var result = await _userM.CreateAsync(model.GetUser(),model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else {
                foreach (var error in result.Errors) 
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
        }

        public async Task<IActionResult> SingOut() 
        {
            await _userS.SignOutAsync();
            return LocalRedirect("/");
        }



    }
}
