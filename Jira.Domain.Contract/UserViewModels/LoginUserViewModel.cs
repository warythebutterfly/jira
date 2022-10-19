using System;
using System.Collections.Generic;
using System.Text;

namespace Jira.Domain.Contract.UserViewModels
{
    public class LoginUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
