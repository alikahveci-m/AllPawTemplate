using AllPawTemplate.Models;

namespace AllPawTemplate.Services.AdvertDetailService
{
    public interface IAdvertDetailService
    {
        Task<DetailResponse> GetAdvertDetailAsync(int advertId);
    }
}
