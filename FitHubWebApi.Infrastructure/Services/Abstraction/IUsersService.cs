using System.Threading.Tasks;
using FitHubWebApi.Core.Domain;

namespace FitHubWebApi.Infrastructure.Services.Abstraction
{
    public interface IUsersService : IService<User>
    {
        bool IsPasswordValid(string login, string password);
        Task<User> GetByEmail(string email);
    }
}
