using AllPawTemplate.Dtos;
using AllPawTemplate.Models.DapperContext;
using Dapper;

namespace AllPawTemplate.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            string query = "Select * From [AllPawTemplate].[dbo].[User]";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<User>(query);
                return values.ToList();
            }
        }
    }
}
