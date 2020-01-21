using System.Threading.Tasks;
using FitHubWebApi.Core.DTO;

namespace FitHubWebApi.Infrastructure.Services.Abstraction
{
    public interface IUsersService : IService<UserDTO>
    {
        Task<bool> IsPasswordValid(string login, string password);
        Task<UserDTO> GetByEmail(string email);
    }
}
