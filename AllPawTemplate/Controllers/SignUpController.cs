using AllPawTemplate.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AllPawTemplate.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserSignUpModelDto model)
        {
            if (ModelState.IsValid)
            {
                // Burada kullanıcıyı veritabanına kaydedebilirsiniz.
                // Örneğin, Identity Framework veya başka bir kimlik doğrulama yöntemi kullanabilirsiniz.

                // Başarılı kayıt sonrası bir yönlendirme yapabilirsiniz.
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(model.Password);
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
