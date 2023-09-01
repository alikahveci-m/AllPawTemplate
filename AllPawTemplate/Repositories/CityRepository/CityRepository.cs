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

        public async Task<City> GetCityByAdvertId(int advertId)
        {
            string query = @"Select c.CityId, c.CityName
                             From [AllPawTemplate].[dbo].[City] c WITH(NOLOCK)
                             INNER JOIN [AllPawTemplate].[dbo].[Advert] a WITH(NOLOCK) 
                             ON c.CityId = a.CityId WHERE a.AdvertId = @advertId";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@advertId", advertId);

                var values = await connection.QueryFirstOrDefaultAsync<City>(query, parameters);
                return values;
            }
        }
    }
}
