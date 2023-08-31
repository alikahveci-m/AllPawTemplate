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

        public async void CreateUser(User user)
        {
            string query = @"INSERT INTO dbo.[User] (UserType, PackageType, Username, Email, PasswordHash, FirstName, LastName, ProfilePhoto, PhoneNumber, RegistrationDate)
                     VALUES (@UserType, @PackageType, @Username, @Email, @PasswordHash, @FirstName, @LastName, @ProfilePhoto, @PhoneNumber, @RegistrationDate)";
            using (var connection = _context.CreateConnection())
            {
                var paramaters = new DynamicParameters();

                paramaters.Add("@UserType", user.UserType);
                paramaters.Add("@PackageType", user.PackageType);
                paramaters.Add("@Username", user.Username);
                paramaters.Add("@Email", user.Email);
                paramaters.Add("@PasswordHash", user.PasswordHash);
                paramaters.Add("@FirstName", user.FirstName);
                paramaters.Add("@LastName", user.LastName);
                paramaters.Add("@ProfilePhoto", user.ProfilePhoto);
                paramaters.Add("@PhoneNumber", user.PhoneNumber);
                paramaters.Add("@RegistrationDate", user.RegistrationDate);

                await connection.ExecuteAsync(query,paramaters);
            }
        }

        public async Task<bool> LoginAsync(UserLoginModelDto userLoginModel)
        {
            userLoginModel.Password = BCrypt.Net.BCrypt.HashPassword(userLoginModel.Password);
            string query = "Select * From [dbo].[User] WITH(NOLOCK) WHERE Email = @email AND PasswordHash = @password";

            using (var connection = _context.CreateConnection())
            {
                var paramaters = new DynamicParameters();

                paramaters.Add("@email", userLoginModel.Email);
                paramaters.Add("@password", userLoginModel.Password);

                var values = await connection.QueryAsync<User>(query, paramaters);
                return values.Any();
            }
        }
    }
}
