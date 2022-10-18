using System;
using System.Collections.Generic;
using System.Text;

namespace Jira.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string EmailAddress { get; set; }
    }
}
