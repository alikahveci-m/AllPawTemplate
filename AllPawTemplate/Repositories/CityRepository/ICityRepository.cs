using AllPawTemplate.Dtos;

namespace AllPawTemplate.Repositories.CityRepository
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCityAsync();
    }
}
