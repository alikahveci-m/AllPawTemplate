using AllPawTemplate.Models;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.ImageRepository;
using AllPawTemplate.Repositories.UserRepository;

namespace AllPawTemplate.Services.AdvertDetailService
{
    public class AdvertDetailService : IAdvertDetailService
    {
        private readonly IUserRepository _userRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IAdvertRepository _advertRepository;

        public AdvertDetailService(IUserRepository userRepository,
            IImageRepository imageRepository,
            IAdvertRepository advertRepository)
        {
            _userRepository = userRepository;
            _imageRepository = imageRepository;
            _advertRepository = advertRepository;
        }

        public async Task<DetailResponse> GetAdvertDetail(int advertId)
        {
            var user = await _userRepository.GetUserByAdvertId(advertId);
            var advert = await _advertRepository.GetAdvertByIdAsync(advertId);
            var images = await _imageRepository.GetImagesByAdvertIdAsync(advertId);


            var response = new DetailResponse
            {

            };

            return response;
        }
    }
}
