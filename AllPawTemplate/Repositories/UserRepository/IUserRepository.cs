﻿using AllPawTemplate.Dtos;
using AllPawTemplate.Enitities;

namespace AllPawTemplate.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUserAsync();
        void CreateUser(User user);
        Task<bool> LoginAsync(UserLoginModelDto userLoginModel);
        Task<User> GetUserByAdvertId(int advertId);
    }
}
