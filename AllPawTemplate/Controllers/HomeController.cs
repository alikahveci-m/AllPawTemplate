using AllPawTemplate.Dtos;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;

namespace AllPawTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepository;
        private readonly IAdvertRepository _advertRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository, IAdvertRepository advertRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
            _advertRepository = advertRepository;
        }

        public async Task<IActionResult> Index()
        {
            var ea = await _userRepository.GetAllUserAsync();
            var response = await _advertRepository.GetAllAdvertAsync();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> ApplyFilters([FromBody] FilterDto filters)
        {
            // Burada filtreleri kullanarak Advert'ları filtreleyin
            // Örnek olarak, _advertRepository üzerinden filtreleri kullanarak filtrelenmiş Advert listesi alabilirsiniz

            // Filtrelenmiş Advert listesini JSON olarak dönün
            var filteredAdverts = await _advertRepository.GetAllAdvertAsync();
            return Json(filteredAdverts);
        }
        public IActionResult CreateAdvert()
        {
            return View();
        }
        public IActionResult ShopDetails()
        {
            return View();
        }
        public IActionResult Members()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
        public IActionResult OurContact()
        {
            return View();
        }

        public IActionResult PricingPlan()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}