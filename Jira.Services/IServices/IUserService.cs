using Jira.Domain.Contract.UserViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jira.Services.IServices
{
    public interface IUserService
    {
        Task<UserViewModel> CreateUser(UserViewModel model);
        Task<UserViewModel> AuthenticateUser(LoginUserViewModel model);
        Task<List<UserViewModel>> GetUser();
        Task<UserViewModel> GetUser(int id);
        Task<UserViewModel> UpdateUser(UserViewModel model);
        Task<string> DeleteUser(int id);
        Task<string> DisableUser(int id);
    }

    
}
