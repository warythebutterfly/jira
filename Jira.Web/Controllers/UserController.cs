using Jira.Domain.Contract.UserViewModels;
using Jira.Helpers.Formatting;
using Jira.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jira.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            userService = _userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        [Route("createUser")]
        [HttpPost]
        public async Task<DataResult> CreateUser(UserViewModel model)
        {
            DataResult dataResult;
            try
            {
                if (!ModelState.IsValid)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "400",
                        Message = "Bad Request",
                        Data = false
                    };
                }

                try
                {
                    object data = await _userService.CreateUser(model);
                    dataResult = new DataResult
                    {
                        StatusCode = "200",
                        Message = "Successful",
                        Data = data
                    };
                }
                catch (Exception ex)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "404",
                        Message = ex.Message,
                        Data = false
                    };
                }
            }

            catch (Exception ex)
            {
                dataResult = new DataResult
                {
                    StatusCode = "406",
                    Message = "Unknown Error",
                    ExceptionErrorMessage = ex.Message,
                    Data = null
                };
            }
            return dataResult;
        }

        [Route("getUsers")]
        [HttpGet]
        public async Task<DataResult> GetUser()
        {
            DataResult dataResult;
            try
            {
                if (!ModelState.IsValid)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "400",
                        Message = "Bad Request",
                        Data = false
                    };
                }

                try
                {
                    object data = await _userService.GetUser();
                    dataResult = new DataResult
                    {
                        StatusCode = "200",
                        Message = "Successful",
                        Data = data
                    };
                }
                catch (Exception ex)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "404",
                        Message = ex.Message,
                        Data = false
                    };
                }
            }

            catch (Exception ex)
            {
                dataResult = new DataResult
                {
                    StatusCode = "406",
                    Message = "Unknown Error",
                    ExceptionErrorMessage = ex.Message,
                    Data = null
                };
            }
            return dataResult;
        }

        [Route("getUser")]
        [HttpGet]
        public async Task<DataResult> GetUser(int id)
        {
            DataResult dataResult;
            try
            {
                if (!ModelState.IsValid)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "400",
                        Message = "Bad Request",
                        Data = false
                    };
                }

                try
                {
                    object data = await _userService.GetUser(id);
                    dataResult = new DataResult
                    {
                        StatusCode = "200",
                        Message = "Successful",
                        Data = data
                    };
                }
                catch (Exception ex)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "404",
                        Message = ex.Message,
                        Data = false
                    };
                }
            }

            catch (Exception ex)
            {
                dataResult = new DataResult
                {
                    StatusCode = "406",
                    Message = "Unknown Error",
                    ExceptionErrorMessage = ex.Message,
                    Data = null
                };
            }
            return dataResult;
        }

        [Route("updateUser")]
        [HttpPut]
        public async Task<DataResult> UpdateUser(UserViewModel model)
        {
            DataResult dataResult;
            try
            {
                if (!ModelState.IsValid)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "400",
                        Message = "Bad Request",
                        Data = false
                    };
                }

                try
                {
                    object data = await _userService.UpdateUser(model);
                    dataResult = new DataResult
                    {
                        StatusCode = "200",
                        Message = "Successful",
                        Data = data
                    };
                }
                catch (Exception ex)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "404",
                        Message = ex.Message,
                        Data = false
                    };
                }
            }

            catch (Exception ex)
            {
                dataResult = new DataResult
                {
                    StatusCode = "406",
                    Message = "Unknown Error",
                    ExceptionErrorMessage = ex.Message,
                    Data = null
                };
            }
            return dataResult;
        }

        [Route("deleteUser")]
        [HttpPut]
        public async Task<DataResult> DeleteUser(int id)
        {
            DataResult dataResult;
            try
            {
                if (!ModelState.IsValid)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "400",
                        Message = "Bad Request",
                        Data = false
                    };
                }

                try
                {
                    object data = await _userService.DeleteUser(id);
                    dataResult = new DataResult
                    {
                        StatusCode = "200",
                        Message = "Successful",
                        Data = data
                    };
                }
                catch (Exception ex)
                {
                    dataResult = new DataResult
                    {
                        StatusCode = "404",
                        Message = ex.Message,
                        Data = false
                    };
                }
            }

            catch (Exception ex)
            {
                dataResult = new DataResult
                {
                    StatusCode = "406",
                    Message = "Unknown Error",
                    ExceptionErrorMessage = ex.Message,
                    Data = null
                };
            }
            return dataResult;
        }
    }
}
