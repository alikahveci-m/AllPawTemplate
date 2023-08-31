using AllPawTemplate.Dtos;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.UserRepository;
using AllPawTemplate.Services.HomeService;
using Microsoft.AspNetCore.Mvc;

namespace AllPawTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _homeService.GetHome();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> ApplyFilters([FromBody] FilterDto filters)
        {
            // Burada filtreleri kullanarak Advert'ları filtreleyin
            // Örnek olarak, _advertRepository üzerinden filtreleri kullanarak filtrelenmiş Advert listesi alabilirsiniz

            // Filtrelenmiş Advert listesini JSON olarak dönün
            var filteredAdverts = await _homeService.GetHome();
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
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}