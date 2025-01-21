using Hinamori.Data;
using Hinamori.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hinamori.Controllers
{
    public class LoginAccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        // GET: LoginAccountController
        public LoginAccountController(ApplicationDbContext context) { _context = context; }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                string? email = _context.UserInfos.Find(login.Email).ToString();

                if (email == null)
                {
                    login.EmailValidation = "invalid emailid";
                }

            }

            return View(login);
        }
    }
}