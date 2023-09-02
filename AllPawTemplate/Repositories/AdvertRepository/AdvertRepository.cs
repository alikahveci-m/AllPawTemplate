using AllPawTemplate.Enitities;
using AllPawTemplate.Models.DapperContext;
using Dapper;
using System.Data;

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

        public async Task<List<Advert>> GetAllAdvertAfterFilterAsync(List<int> filters)
        {
            string filterString = string.Join(",", filters);

            string query = $"Select * From [AllPawTemplate].[dbo].[Advert] WITH(NOLOCK) WHERE CategoryId IN ({filterString})";

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

        public async void UpdateViewCount(int advertId)
        {
            string query = @"UPDATE [AllPawTemplate].[dbo].[Advert] SET [ViewCount] = [ViewCount] + 1 WHERE AdvertId = @advertId";
            using (var connection = _context.CreateConnection())
            {
                var paramaters = new DynamicParameters();

                paramaters.Add("@advertId", advertId);

                await connection.ExecuteAsync(query, paramaters);
            }
        }

        public async Task<List<Advert>> GetUserAdvertsByIdAsync(int userId)
        {
            string query = "Select * From [AllPawTemplate].[dbo].[Advert] WITH(NOLOCK) WHERE UserId=@userId";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@userId", userId);
                var values = await connection.QueryAsync<Advert>(query, parameters);
                return values.ToList();

            }
        }
    }
}
