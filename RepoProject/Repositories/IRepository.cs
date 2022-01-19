using System.Threading.Tasks;

namespace RepoProject.Repositories
{
    public interface IRepository
    {
        Task Create(Models.Repository rep);
    }
}