using AllPawTemplate.Dtos;
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
            var filteredAdverts = await _homeService.GetHomeAfterFilter(filters.Breeds);
            return Json(filteredAdverts);
        }

        public async Task<IActionResult> FilteredAdverts(FilterDto filters)
        {
            var filteredAdverts = await _homeService.GetHomeAfterFilter(filters.Breeds);
            return View(filteredAdverts);
        }

        public IActionResult PopupSuccess()
        {
            return View();
        }

        public IActionResult PopupError()
        {
            return View();
        }

        public IActionResult CreateAdvert()
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