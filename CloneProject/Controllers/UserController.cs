using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CloneProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersService _usersService;

        public UserController(IUsersService usersService);
            private readonly IPostService PostService
            {
                _usersService = usersService
            }  

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                // Burada gerekli kontrolleri yapabilir ve kullanıcı nesnesini ekleyebilirsiniz.
                _usersService.UserAdd(user);

                return RedirectToAction("TwitterHome", "Home"); // Veya başka bir sayfaya yönlendirin.
            }

            return View(user);
        }
      
    }
}
