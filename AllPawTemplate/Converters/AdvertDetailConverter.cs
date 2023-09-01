using AllPawTemplate.Dtos;
using AllPawTemplate.Enitities;
using AllPawTemplate.Extensions;

namespace AllPawTemplate.Converters
{
    public static class AdvertDetailConverter
    {
        public static AdvertDetailDto AdvertDetail(Advert advert, City city, Images images, Category category)
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
                CreationDate = advert.CreationDate,
                Description = advert.Description,
                Gender = advert.Gender,
                Price = advert.Price,
                SubImages = images.ImageUrl.
                FormattedPrice = advert.Price.FormatAsPrice(),
            };
        }
    }
}
