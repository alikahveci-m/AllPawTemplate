using AllPawTemplate.Dtos;

namespace AllPawTemplate.Services.LoginService
{
    public interface ILoginService
    {
        Task<bool> LoginAsync(UserLoginModelDto loginModel);
    }
}
