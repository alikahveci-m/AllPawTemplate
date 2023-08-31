using AllPawTemplate.Dtos;
using AllPawTemplate.Repositories.UserRepository;

namespace AllPawTemplate.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;

        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> LoginAsync(UserLoginModelDto loginModel)
        {
            return await _userRepository.LoginAsync(loginModel);
        }
    }
}
