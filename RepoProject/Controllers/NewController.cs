using Microsoft.AspNetCore.Mvc;
using RepoProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoProject.Controllers
{
    [ApiController]
    [Route("new")]
    public class NewController : ControllerBase
    {
        private readonly IRepository repository;
        public NewController(IRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public async Task CreateRep(Models.Repository rep)
        {
            await repository.Create(rep);
        }
    }
}
