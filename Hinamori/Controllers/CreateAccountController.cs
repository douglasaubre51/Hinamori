using Hinamori.Data;
using Hinamori.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hinamori.Controllers
{
    public class CreateAccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        // GET: CreateAccountController
        public CreateAccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                _context.UserInfos.Add(userInfo);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(userInfo);
        }
    }
}