using System;
using System.Collections.Generic;
using System.Text;

namespace Jira.Domain.Entities
{
    public class Issue : BaseEntity
    {
        public int Type { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public User Reporter { get; set; }

    }
}
