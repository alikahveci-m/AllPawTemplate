using AllPawTemplate.Enitities;

namespace AllPawTemplate.Repositories.CityRepository
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCityAsync();
    }
}
