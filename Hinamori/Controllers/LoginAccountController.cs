using Microsoft.AspNetCore.Mvc;
using Hinamori.Data;
using Hinamori.ViewModels;

namespace Hinamori.Controllers
{
    public class LoginAccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginAccountController(ApplicationDbContext context) { _context = context; }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = _context.UserInfos.FirstOrDefault(e => e.Email == loginVM.EmailValidation);

                if (user == null)
                {
                    ViewBag.ValidateEmail = "invalid emailid!";
                    return View(loginVM);
                }

                if (user.Password != loginVM.PasswordValidation)
                {
                    ViewBag.ValidatePassword = "wrong password!";
                    return View(loginVM);
                }

                ViewBag.Success = "successfully logged in!";
                return RedirectToAction("Index", "Chatter");
            }

            return View(loginVM);
        }
    }
}