using AllPawTemplate.Dtos;

namespace AllPawTemplate.Services.SignupService
{
    public interface ISignupService
    {
        void CreateUser(UserSignupModelDto user);
    }
}
