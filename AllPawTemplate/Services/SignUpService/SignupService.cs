using AllPawTemplate.Dtos;
using AllPawTemplate.Enitities;
using AllPawTemplate.Repositories.UserRepository;

namespace AllPawTemplate.Services.SignupService
{
    public class SignupService : ISignupService
    {
        private readonly IUserRepository _userRepository;

        public SignupService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(UserSignupModelDto user)
        {
            var userModel = new User
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserType = user.AcceptPetShopTerms == true ? 1 : 0,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password),
                RegistrationDate = DateTime.Now,
                PackageType = 0,
                PhoneNumber = null,
                ProfilePhoto = null,
            };

            _userRepository.CreateUser(userModel);
        }
    }
}
