using System;
using System.Collections.Generic;
using System.Text;

namespace Jira.Domain.Contract.UserViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string EmailAddress { get; set; }

        //password

        
    }
}
