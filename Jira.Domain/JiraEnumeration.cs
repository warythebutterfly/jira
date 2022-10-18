using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jira.Domain
{
    public class JiraEnumeration
    {
        public enum Type
        {
            Task = 1,
            Bug,
            Story

        }

        public enum Priority
        {
            Lowest = 1,
            Low,
            Medium,
            High, 
            Highest

        }

        public enum Status
        {
            [Display(Name = "To Do")]
            Todo = 1,
            [Display(Name = "In Progress")]
            In_Progress,
            [Display(Name = "Done")]
            Done
        }
    }
}
