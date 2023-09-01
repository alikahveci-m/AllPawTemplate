using AllPawTemplate.Services.AdvertDetailService;
using Microsoft.AspNetCore.Mvc;

namespace AllPawTemplate.Controllers
{
    public class AdvertDetailController : Controller
    {
        private readonly IAdvertDetailService _advertDetailService;

        public AdvertDetailController(IAdvertDetailService advertDetailService)
        {
            _advertDetailService = advertDetailService;
        }

        public async Task<IActionResult> AdvertDetail(int advertId)
        {
            var response = await _advertDetailService.GetAdvertDetailAsync(advertId);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }
    }
}
