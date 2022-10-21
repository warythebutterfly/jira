using Jira.Domain.Contract.IssueViewModels;
using Jira.Helpers.Formatting;
using Jira.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jira.Web.Controllers
{
    public class IssueController : Controller
    {
        private readonly IIssueService _issueService;

        public IssueController(IIssueService issueService)
        {
            issueService = _issueService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }public IActionResult CreateIssue()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }

        [Route("createIssue")]
        [HttpPost]
        public async Task<DataResult> CreateIssue(CreateIssueViewModel model)
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
                    object data = await _issueService.CreateIssue(model);
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

        [Route("getIssues")]
        [HttpGet]
        public async Task<DataResult> GetIssue()
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
                    object data = await _issueService.GetIssue();
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

        [Route("getIssue")]
        [HttpGet]
        public async Task<DataResult> GetIssue(int id)
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
                    object data = await _issueService.GetIssue(id);
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

        [Route("updateIssue")]
        [HttpPut]
        public async Task<DataResult> UpdateIssue(UpdateIssueViewModel model)
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
                    object data = await _issueService.UpdateIssue(model);
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
