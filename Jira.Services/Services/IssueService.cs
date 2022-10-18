using Jira.Domain.Contract.IssueViewModels;
using Jira.Domain.Contract.UserViewModels;
using Jira.Domain.Entities;
using Jira.EntityFrameworkCore;
using Jira.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Jira.Domain.JiraEnumeration;
using Type = Jira.Domain.JiraEnumeration.Type;

namespace Jira.Services.Services
{
    public class IssueService : IIssueService
    {
        private JiraDbContext _db;
        public IssueService(JiraDbContext jiraDbContext)
        {
            _db = jiraDbContext;
        }
        public async Task<List<IssueViewModel>> GetIssue()
        {
            //try catch
            //async
            //repoter and assignee
            try
            {
                var issues = await _db.Issues.Select(x => new IssueViewModel
                {
                    Type = ((Type)x.Type).ToString(),
                    Status = ((Status)x.Status).ToString(),
                    CreatedOn = x.CreatedOn.ToLongDateString(),
                    UpdatedOn = x.UpdatedOn.ToLongDateString(),
                    Summary = x.Summary,
                    Description = x.Description,
                    Reporter = new UserViewModel
                    {
                        Id = x.Reporter.Id,
                        Firstname = x.Reporter.Firstname,
                        Lastname = x.Reporter.Lastname,
                    },
                    Assignee = new UserViewModel
                    {
                        Id = x.Assignee.Id,
                        Firstname = x.Assignee.Firstname,
                        Lastname = x.Assignee.Lastname,
                    }

                }).ToListAsync();

                if (issues == null) throw new Exception("No issues found");

                return issues;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IssueViewModel> GetIssue(int id)
        {
            try
            {
                var issue = await _db.Issues.Where(x => x.Id == id).Select(x => new IssueViewModel
                {
                    
                    Type = ((Type)x.Type).ToString(),
                    Status = ((Status)x.Status).ToString(),
                    CreatedOn = x.CreatedOn.ToLongDateString(),
                    UpdatedOn = x.UpdatedOn.ToLongDateString(),
                    Summary = x.Summary,
                    Description = x.Description,
                    Reporter = new UserViewModel
                    {
                        Id = x.Reporter.Id,
                        Firstname = x.Reporter.Firstname,
                        Lastname = x.Reporter.Lastname,
                    },
                    Assignee = new UserViewModel
                    {
                        Id = x.Assignee.Id,
                        Firstname = x.Assignee.Firstname,
                        Lastname = x.Assignee.Lastname,
                    }

                }).FirstOrDefaultAsync();

                if (issue == null) throw new Exception("No issue found");

                return issue;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IssueViewModel> CreateIssue(CreateIssueViewModel issueViewModel)
        {
            try
            {
                var issue = new Issue
                {
                    Type = (int)(Type)Enum.Parse(typeof(Type), issueViewModel.Type),
                    Status = (int)(Type)Enum.Parse(typeof(Status), issueViewModel.Status),
                    Priority = (int)(Priority)Enum.Parse(typeof(Priority), issueViewModel.Priority),
                    Summary = issueViewModel.Summary,
                    Description = issueViewModel.Description,
                    Reporter = _db.Users.Where(x => x.Id == issueViewModel.UserId).FirstOrDefault(),
                    Assignee = _db.Users.Where(x => x.Id == issueViewModel.Assignee.Id).FirstOrDefault(),
                    CreatedOn = DateTime.Now,
                };

                await _db.Issues.AddAsync(issue);
                await _db.SaveChangesAsync();

                return new IssueViewModel
                {
                    Message = $"You've created 'TEAM - {issue.Id}' issue",
                    IssueId = issue.Id
                };

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IssueViewModel> UpdateIssue(UpdateIssueViewModel model)
        {
            try
            {
                if (model == null || model.UserId < 1 || model.IssueId < 1)
                    throw new Exception("Id is not provided.");

                //get the reporter
                var reporter = await _db.Users.FindAsync(model.UserId);

                //get the issue
                var issue = await _db.Issues.FindAsync(model.IssueId);

                if (reporter.Id == issue.Reporter.Id)
                {
                    try
                    {
                        //update the issue

                        if (issue == null)
                            throw new Exception("This issue cannot be retrieved at the moment.");

                        issue.Type = string.IsNullOrEmpty(model.Type) ? issue.Type : (int)(Type)Enum.Parse(typeof(Type), model.Type);
                        issue.Status = string.IsNullOrEmpty(model.Status) ? issue.Status : (int)(Type)Enum.Parse(typeof(Type), model.Status);
                        issue.Priority = string.IsNullOrEmpty(model.Priority) ? issue.Priority : (int)(Type)Enum.Parse(typeof(Type), model.Priority);
                        issue.Summary = string.IsNullOrEmpty(model.Summary) ? issue.Summary : model.Summary;
                        issue.Description = string.IsNullOrEmpty(model.Description) ? issue.Description : model.Description;
                        issue.Assignee = await _db.Users.FindAsync(model.Assignee.Id);

                        _db.Entry(issue).State = EntityState.Modified;
                        await _db.SaveChangesAsync();

                        return new IssueViewModel
                        {
                            IssueId = issue.Id,
                            Summary = issue.Summary,
                            Description = issue.Description,
                            Type = ((Type)issue.Type).ToString(),
                            Status = ((Status)issue.Status).ToString(),
                            Priority = ((Priority)issue.Priority).ToString(),
                            Assignee = new UserViewModel
                            {
                                Id = issue.Assignee.Id,
                                Firstname = issue.Assignee.Firstname,
                                Lastname = issue.Assignee.Lastname
                            }
                        };

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

                throw new Exception("You cannot edit this issue you're not the reporter");
            
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
