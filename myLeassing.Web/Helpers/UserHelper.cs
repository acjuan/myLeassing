using Microsoft.AspNetCore.Identity;
using MyLeasing.Web.Helpers;
using myLeassing.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLeassing.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        public Task<IdentityResult> AddUserAsync(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task AddUserToRoleAsync(User user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task CheckRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
