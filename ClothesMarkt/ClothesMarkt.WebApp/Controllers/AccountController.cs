using ClothesMarkt.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ClothesMarkt.WebApp.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<IdentityUser<int>> _userManager;
        private SignInManager<IdentityUser<int>> _signInManager;

        public AccountController( UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager)
        {

            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            IdentityUser<int>? user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("UserNotFound", "Kullanıcı adı veya şifre yanlıştır");

                return View(model);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

            if (signInResult.IsLockedOut)
            {
                //return View(nameof(LockedOut));

                ModelState.AddModelError("UserLocked", "Hesabınız kilitlenmiştir");

                return View(model);
            }

            if (signInResult.IsNotAllowed)
            {
                //return View(nameof(LockedOut));

                ModelState.AddModelError("UserLocked", "Hesabınız henüz aktif değildir. Lütfen email adresinizi doğrulayınız.");

                return View(model);
            }

            if (signInResult.RequiresTwoFactor)
            {
                return View(nameof(LoginTwoFactor));
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("LoginFail", "Kullanıcı adı veya şifre yanlıştır");

                return View(model);
            }


            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Login));
        }

        public IActionResult LockedOut()
        {
            return View();
        }

        public IActionResult LoginTwoFactor()
        {
            return View();
        }
    }
}

