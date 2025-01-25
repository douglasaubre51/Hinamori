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
                string? email = _context.UserInfos.Find(loginVM.Email).ToString();

                if (email == null)
                {
                    ViewBag.ValidateEmail = "invalid emailid!";
                    return View(loginVM);
                }

                string? password = _context.UserInfos.Where(e => e.Email == email && e.Password == loginVM.Password).ToString();

                if (password == null)
                {
                    ViewBag.ValidatePassword = "wrong password!";
                    return View(loginVM);
                }

                ViewBag.Success = "successfully logged in!";
                return View(loginVM);
                // return RedirectToAction("Index", "Chatter");
            }

            return View(loginVM);
        }
    }
}