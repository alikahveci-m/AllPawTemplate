using AllPawTemplate.Dtos;
using AllPawTemplate.Services.SignupService;
using Microsoft.AspNetCore.Mvc;

namespace AllPawTemplate.Controllers
{
    public class SignupController : Controller
    {
        private readonly ISignupService _signupService;

        public SignupController(ISignupService signupService)
        {
            _signupService = signupService;
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserSignupModelDto model)
        {
            if (ModelState.IsValid)
            {
                _signupService.CreateUser(model);
                //return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
