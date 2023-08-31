using AllPawTemplate.Dtos;
using AllPawTemplate.Services.LoginService;
using Microsoft.AspNetCore.Mvc;

namespace AllPawTemplate.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserLoginModelDto loginModel)
        {
            var response = _loginService.LoginAsync(loginModel);

            return RedirectToAction("LoggedIn"); // Örnek olarak giriş başarılıysa LoggedIn adlı bir View'e yönlendirilebilir.
        }

        public IActionResult LoggedIn()
        {
            // Giriş yapan kullanıcının sayfasına yönlendirme yapabilirsiniz.
            return View();
        }
    }
}
