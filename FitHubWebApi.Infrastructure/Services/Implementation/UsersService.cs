using AutoMapper;
using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.Services.Abstraction;
using System.Threading.Tasks;

namespace FitHubWebApi.Infrastructure.Services.Implementation
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;
        public UsersService(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
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

        public async Task<User> GetById(int id)
        {
            var domainUser = await _usersRepository.GetById(id); 

            return domainUser;
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
