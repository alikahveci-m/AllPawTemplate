using AllPawTemplate.Dtos;

namespace AllPawTemplate.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUserAsync();
        void CreateUser(User user);
        Task<bool> LoginAsync(UserLoginModelDto userLoginModel);
    }
}
