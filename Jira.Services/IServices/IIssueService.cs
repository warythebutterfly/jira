using Jira.Domain.Contract.IssueViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jira.Services.IServices
{
    public interface IIssueService
    {
        Task<IssueViewModel> CreateIssue(CreateIssueViewModel model);
        Task<List<IssueViewModel>> GetIssue();
        Task<IssueViewModel> GetIssue(int id);
        Task<IssueViewModel> UpdateIssue(UpdateIssueViewModel model);
        
    }
}
