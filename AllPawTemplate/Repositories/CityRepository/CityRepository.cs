using AllPawTemplate.Enitities;
using AllPawTemplate.Models.DapperContext;
using Dapper;

namespace AllPawTemplate.Repositories.CityRepository
{
    public class CityRepository : ICityRepository
    {
        private readonly Context _context;

        public CityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllCityAsync()
        {
            string query = "Select * From [AllPawTemplate].[dbo].[City]";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<City>(query);
                return values.ToList();
            }
        }
    }
}
