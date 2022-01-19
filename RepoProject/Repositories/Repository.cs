using RepoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoProject.Repositories
{
    public class Repository : IRepository
    {
        private readonly RepositoriesContext context;
        public Repository(RepositoriesContext context)
        {
            this.context = context;
        }
        public async Task Create(Models.Repository rep)
        {
            await context.Repository.AddAsync(rep);
            await context.SaveChangesAsync();
        }
    }
}
