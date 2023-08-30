using AllPawTemplate.Dtos;

namespace AllPawTemplate.Models
{
    public class HomeResponse
    {
        public List<Advert> Adverts { get; set; }
        public List<City> Cities { get; set; }
        public List<Category> Categories { get; set; }
    }
}
