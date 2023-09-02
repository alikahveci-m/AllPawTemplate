using AllPawTemplate.Dtos;
using AllPawTemplate.Enitities;
using AllPawTemplate.Extensions;

namespace AllPawTemplate.Converters
{
    public static class AdvertDetailConverter
    {
        public static AdvertDetailDto AdvertDetail(Advert advert, City city, List<Images> images, Category category)
        {
            var response = new AdvertDetailDto
            {
                Active = advert.Active,
                AdvertId = advert.AdvertId,
                AdvertPhoto = advert.AdvertPhoto,
                CategoryId = advert.CategoryId,
                CategoryName = category.CategoryName,
                CityId = advert.CityId,
                CityName = city.CityName,
                CountryName = "",
                CreationDate = advert.CreationDate.ToCustomDateString(),
                Description = advert.Description,
                Gender = advert.Gender,
                Price = advert.Price,
                SubImages = images.Select(x => x.ImageUrl).ToList(),
                FormattedPrice = advert.Price.FormatAsPrice(),
                Title = advert.Title,
                UserId = advert.UserId,
                ViewCount = advert.ViewCount,
                Vitrine = advert.Vitrine,
                Year = advert.Year
            };

            return response;
        }

        public static UserAdvertDto UserDetail(User user, List<Advert> adverts)
        {
            var response = new UserAdvertDto
            {
                Adverts = adverts,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PackageType = user.PackageType,
                PasswordHash = user.PasswordHash,
                PhoneNumber = user.PhoneNumber,
                ProfilePhoto = user.ProfilePhoto,
                RegistrationDate = user.RegistrationDate.ToCustomDateString(),
                UserId = user.UserId,
                UserType = user.UserType,
            };

            return response;
        }
    }
}
