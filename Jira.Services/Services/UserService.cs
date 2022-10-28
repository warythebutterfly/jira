using Jira.Domain.Contract.UserViewModels;
using Jira.Domain.Entities;
using Jira.EntityFrameworkCore;
using Jira.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira.Services.Services
{
    public class UserService : IUserService
    {
        private JiraDbContext _db;

        public UserService(JiraDbContext jiraDbContext)
        {
            _db = jiraDbContext;
        }
        public async Task<UserViewModel> AuthenticateUser(LoginUserViewModel model)
        {
            //var emailExists = await _db.Users.Select(x => x.EmailAddress).Where(email => email == model.Email).AnyAsync();
            var user = await _db.Users.Where(x => x.EmailAddress == model.Email).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("This email does not exist");
            }
            var isPasswordCorrect = BCrypt.Net.BCrypt.Verify(model.Password, user.Password);
            if (isPasswordCorrect)
            {
                return new UserViewModel
                {
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Id = user.Id,
                    JobTitle = user.JobTitle,
                    Department = user.Department,
                    EmailAddress = user.EmailAddress
                };
            }
            else
            {
                throw new Exception("Email or password incorrect");
            }
        }

        public async Task<UserViewModel> CreateUser(UserViewModel model)
        {
            try
            {
                var user = new User
                {
                    Id = model.Id,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    JobTitle = model.JobTitle,
                    Department = model.Department,
                    EmailAddress = model.EmailAddress,
                    CreatedOn = DateTime.Now,
                    Password = BCrypt.Net.BCrypt.HashPassword(model.Password)
                };

                await _db.Users.AddAsync(user);
                await _db.SaveChangesAsync();

                return new UserViewModel
                {
                    Id = user.Id,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    JobTitle = user.JobTitle,
                    Department = user.Department,
                    EmailAddress = user.EmailAddress,
                };

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> DeleteUser(int id)
        {
            try
            {
                var userToBeDeleted = await _db.Users.FindAsync(id);
                if (userToBeDeleted == null)
                    throw new Exception("Cannot delete a user that doesn't exist");

                _db.Users.Remove(userToBeDeleted);
                await _db.SaveChangesAsync();

                return "User deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> DisableUser(int id)
        {
            try
            {
                var userToBeDeleted = await _db.Users.FirstOrDefaultAsync(user => user.Id == id);
                if (userToBeDeleted == null)
                    throw new Exception("Cannot disable a user that doesn't exist");

                userToBeDeleted.IsDeleted = true;
                userToBeDeleted.IsActive = false;
                userToBeDeleted.DeletedOn = DateTime.Now;

                _db.Entry(userToBeDeleted).State = EntityState.Modified;
                await _db.SaveChangesAsync();

                return "User disabled successfully.";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<UserViewModel>> GetUser()
        {
            try
            {
                var users = await _db.Users.Select(user => new UserViewModel
                {
                    Id = user.Id,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    JobTitle = user.JobTitle,
                    Department = user.Department,
                    EmailAddress = user.EmailAddress
                }).ToListAsync();

                if (users == null) throw new Exception("No users found");

                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UserViewModel> GetUser(int id)
        {
            try
            {
                var user = await _db.Users.Where(user => user.Id == id).Select(user => new UserViewModel
                {
                    Id = user.Id,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    JobTitle = user.JobTitle,
                    Department = user.Department,
                    EmailAddress = user.EmailAddress
                }).FirstOrDefaultAsync();

                if (user == null) throw new Exception("No user found");

                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UserViewModel> UpdateUser(UserViewModel model)
        {
            try
            {
                if (model == null || model.Id < 1)
                    throw new Exception("Id is not provided.");

                //get the user
                var user = await _db.Users.FindAsync(model.Id);

                //update the user
                if (user == null)
                    throw new Exception("This user cannot be retrieved at the moment.");

                user.Firstname = string.IsNullOrEmpty(model.Firstname) ? user.Firstname : model.Firstname;
                user.Lastname = string.IsNullOrEmpty(model.Lastname) ? user.Lastname : model.Lastname;
                user.EmailAddress = string.IsNullOrEmpty(model.EmailAddress) ? user.EmailAddress : model.EmailAddress;
                user.JobTitle = string.IsNullOrEmpty(model.JobTitle) ? user.JobTitle : model.JobTitle;
                user.Department = string.IsNullOrEmpty(model.Department) ? user.Firstname : model.Department;
                user.Password = string.IsNullOrEmpty(model.Password) ? user.Password : model.Password;
                user.UpdatedOn = DateTime.Now;


                _db.Entry(user).State = EntityState.Modified;
                await _db.SaveChangesAsync();

                return new UserViewModel
                {
                    Id = user.Id,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    JobTitle = user.JobTitle,
                    Department = user.Department,
                    EmailAddress = user.EmailAddress,
                };

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
