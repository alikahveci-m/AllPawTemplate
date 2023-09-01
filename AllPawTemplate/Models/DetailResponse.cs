using AllPawTemplate.Dtos;
using AllPawTemplate.Enitities;

namespace AllPawTemplate.Models
{
    public class DetailResponse
    {
        public AdvertDetailDto Advert { get; set; }
        public User User { get; set; }
    }
}
