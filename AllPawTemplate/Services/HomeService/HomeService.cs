using AllPawTemplate.Models;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.CategoryRepository;
using AllPawTemplate.Repositories.CityRepository;
using AllPawTemplate.Repositories.UserRepository;

namespace AllPawTemplate.Services.HomeService
{
    public class HomeService : IHomeService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IAdvertRepository _advertRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeService(IUserRepository userRepository,
            ICityRepository cityRepository,
            IAdvertRepository advertRepository,
            ICategoryRepository categoryRepository)
        {
            _userRepository = userRepository;
            _cityRepository = cityRepository;
            _advertRepository = advertRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<HomeResponse> GetHome()
        {
            var response = new HomeResponse
            {
                Adverts = await _advertRepository.GetAllAdvertAsync(),
                Cities = await _cityRepository.GetAllCityAsync(),
                Categories = await _categoryRepository.GetAllCategoryAsync()
            };

            return response;
        }

        public async Task<DetailResponse> GetAdvertDetail(int advertId)
        {
            var response = new DetailResponse
            {
                Advert = await _advertRepository.GetAdvertByIdAsync(advertId),
                User = await _userRepository.GetUserByAdvertId(advertId),
            };

            return response;
        }
    }
}
