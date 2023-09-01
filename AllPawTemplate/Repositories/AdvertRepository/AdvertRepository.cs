using AllPawTemplate.Enitities;
using AllPawTemplate.Models.DapperContext;
using Dapper;

namespace AllPawTemplate.Repositories.AdvertRepository
{
    public class AdvertRepository : IAdvertRepository
    {
        private readonly Context _context;

        public AdvertRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Advert>> GetAllAdvertAsync()
        {
            string query = "Select * From [AllPawTemplate].[dbo].[Advert]";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Advert>(query);
                return values.ToList();
            }
        }

        public async Task<Advert> GetAdvertByIdAsync(int advertId)
        {
            string query = "Select * From [AllPawTemplate].[dbo].[Advert] WITH(NOLOCK) WHERE AdvertId=@advertId";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@advertId", advertId);
                var values = await connection.QueryFirstOrDefaultAsync<Advert>(query, parameters);
                return values;
            }
        }
    }
}
