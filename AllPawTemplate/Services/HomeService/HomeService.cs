using AllPawTemplate.Models;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.CategoryRepository;
using AllPawTemplate.Repositories.CityRepository;

namespace AllPawTemplate.Services.HomeService
{
    public class HomeService : IHomeService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IAdvertRepository _advertRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeService(ICityRepository cityRepository,
            IAdvertRepository advertRepository,
            ICategoryRepository categoryRepository)
        {
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

        public async Task<HomeResponse> GetHomeAfterFilter(List<string> filters)
        {
            List<int> filterList = new List<int>();

            foreach (string str in filters)
            {
                if (int.TryParse(str, out int intValue))
                {
                    filterList.Add(intValue);
                }
            }

            var response = new HomeResponse
            {
                Adverts = await _advertRepository.GetAllAdvertAfterFilterAsync(filterList),
                Cities = await _cityRepository.GetAllCityAsync(),
                Categories = await _categoryRepository.GetAllCategoryAsync()
            };

            return response;
        }
    }
}
