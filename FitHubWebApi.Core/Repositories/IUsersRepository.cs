using System.Threading.Tasks;
using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories.Base;

namespace FitHubWebApi.Core.Repositories
{
    public interface IUsersRepository : IRepository<User>
    {
        Task<int> GetUsersPasswordHashCode(string login);
    }
}
