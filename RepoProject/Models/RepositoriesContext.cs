using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepoProject.Models
{
    public class RepositoriesContext : DbContext
    {
        public DbSet<Repository> Repository { get; set; }
        public RepositoriesContext(DbContextOptions<RepositoriesContext> dbContext) : base(dbContext)
        {

        }
        
    }
}
