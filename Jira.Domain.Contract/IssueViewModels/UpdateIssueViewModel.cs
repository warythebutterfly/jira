using Jira.Domain.Contract.UserViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jira.Domain.Contract.IssueViewModels
{
    public class UpdateIssueViewModel
    {
        public int UserId { get; set; }
        public int IssueId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public UserViewModel Assignee { get; set; }
        public UserViewModel Reporter { get; set; }
     
    }
}
