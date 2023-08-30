using AllPawTemplate.Models;

namespace AllPawTemplate.Services.HomeService
{
    public interface IHomeService
    {
        Task<HomeResponse> GetHome();
    }
}
