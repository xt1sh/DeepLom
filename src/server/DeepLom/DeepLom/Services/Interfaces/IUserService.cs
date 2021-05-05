using DeepLom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepLom.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string usernameOrEmail, string password);
    }
}
