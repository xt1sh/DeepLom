using DeepLom.Models;
using DeepLom.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepLom.Services
{
    public class UserService : IUserService
    {
        public async Task<User> Authenticate(string usernameOrEmail, string password)
        {
            
        }
    }
}
