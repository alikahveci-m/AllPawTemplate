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
    }
}
