using AllPawTemplate.Enitities;
using AllPawTemplate.Models.DapperContext;
using Dapper;

namespace AllPawTemplate.Repositories.ImageRepository
{
    public class ImageRepository : IImageRepository
    {
        private readonly Context _context;

        public ImageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Images>> GetImagesByAdvertIdAsync(int advertId)
        {
            string query = "Select * From [AllPawTemplate].[dbo].[Images] WITH(NOLOCK) WHERE AdvertId = advertId";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();

                parameters.Add("@advertId", advertId);
                var values = await connection.QueryAsync<Images>(query, parameters);
                return values.ToList();
            }
        }
    }
}
