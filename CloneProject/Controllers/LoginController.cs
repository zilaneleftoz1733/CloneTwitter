using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CloneProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsersService _usersService;

        public LoginController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var a = _usersService.GetAllList().ToList();
            var loginUser = _usersService.GetAllList().FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (loginUser != null)
            {
                ViewBag.Log = "Login Succeeded";
                return RedirectToAction("TwitterHome", "Home");
            }
            else
            {
                ViewBag.Log = "Access Denied";
                return View();
            }
        }
    }
}
