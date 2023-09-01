using AllPawTemplate.Models;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.CategoryRepository;
using AllPawTemplate.Repositories.CityRepository;
using AllPawTemplate.Repositories.ImageRepository;
using AllPawTemplate.Repositories.UserRepository;

namespace AllPawTemplate.Services.AdvertDetailService
{
    public class AdvertDetailService : IAdvertDetailService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IAdvertRepository _advertRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AdvertDetailService(IUserRepository userRepository,
            ICityRepository cityRepository,
            IImageRepository imageRepository,
            IAdvertRepository advertRepository,
            ICategoryRepository categoryRepository)
        {
            _userRepository = userRepository;
            _cityRepository = cityRepository;
            _imageRepository = imageRepository;
            _advertRepository = advertRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<DetailResponse> GetAdvertDetailAsync(int advertId)
        {
            var user = await _userRepository.GetUserByAdvertId(advertId);
            var city = await _cityRepository.GetCityByAdvertId(advertId);
            var advert = await _advertRepository.GetAdvertByIdAsync(advertId);
            var images = await _imageRepository.GetImagesByAdvertIdAsync(advertId);
            var category = await _categoryRepository.GetCategoryByAdvertIdAsync(advertId);


           

            return response;
        }
    }
}
