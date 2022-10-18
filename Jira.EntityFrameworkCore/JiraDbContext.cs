using Jira.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jira.EntityFrameworkCore
{
    public class JiraDbContext : DbContext
    {
        public JiraDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
