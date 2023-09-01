using AllPawTemplate.Enitities;
using AllPawTemplate.Models.DapperContext;
using Dapper;

namespace AllPawTemplate.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            string query = "Select * From [AllPawTemplate].[dbo].[Category]";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Category>(query);
                return values.ToList();
            }
        }

        public async Task<Category> GetCategoryByAdvertIdAsync(int advertId)
        {
            string query = @"Select c.CategoryId, c.CategoryName
                             From [AllPawTemplate].[dbo].[Category] c WITH(NOLOCK)
                             INNER JOIN [AllPawTemplate].[dbo].[Advert] a WITH(NOLOCK) 
                             ON c.CategoryId = a.CategoryId WHERE a.AdvertId = @advertId";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@advertId", advertId);

                var values = await connection.QueryFirstOrDefaultAsync<Category>(query, parameters);
                return values;
            }
        }
    }
}
