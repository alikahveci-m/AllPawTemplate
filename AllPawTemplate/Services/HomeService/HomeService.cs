﻿using AllPawTemplate.Models;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.CityRepository;

namespace AllPawTemplate.Services.HomeService
{
    public class HomeService : IHomeService
    {
        private readonly IAdvertRepository _advertRepository;
        private readonly ICityRepository _cityRepository;
        public HomeService(IAdvertRepository advertRepository, ICityRepository cityRepository)
        {
            _advertRepository = advertRepository;
            _cityRepository = cityRepository;
        }
        public Task<HomeResponse> GetHome()
        {
            throw new NotImplementedException();
        }
    }
}
