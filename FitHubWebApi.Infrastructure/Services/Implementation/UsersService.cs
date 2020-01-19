using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.Services.Abstraction;
using System.Threading.Tasks;

namespace FitHubWebApi.Infrastructure.Services.Implementation
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public bool IsPasswordValid(string login, string password)
        {
            var hashCode = _usersRepository.GetUsersPasswordHashCode(login);
            return (password.GetHashCode() == hashCode.Result);
        }

        public async Task Add(User user)
        {
            await _usersRepository.Add(user);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _usersRepository.GetByEmail(email);
        }

        public async Task<User> GetById(int id)
        {
            return await _usersRepository.GetById(id); 
        }

        public async Task Update(User user)
        {
            await _usersRepository.Update(user);
        }

        public async Task Delete(int id)
        {
            var domainUser = await _usersRepository.GetById(id);
            await _usersRepository.Remove(domainUser);
        }
    }
}
