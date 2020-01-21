using AutoMapper;
using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.DTO;
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

       
        //---CREATE
        public async Task Add(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _usersRepository.Add(user);
        }

        //---READ
        public async Task<UserDTO> GetByEmail(string email)
        {
            var user = await _usersRepository.GetByEmail(email);
            var userDto = _mapper.Map<UserDTO>(user);
            return userDto;
        }

        public async Task<UserDTO> GetById(int id)
        {
            var user = await _usersRepository.GetById(id);
            var userDto = _mapper.Map<UserDTO>(user);

            return userDto;
        }

        //---UPDATE
        public async Task Update(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _usersRepository.Update(user);
        }


        //---DELETE
        public async Task Delete(int id)
        {
            var domainUser = await _usersRepository.GetById(id);
            await _usersRepository.Remove(domainUser);
        }

        //---UTILITIES
        public async Task<bool> IsPasswordValid(string login, string password)
        {
            var user = await _usersRepository.GetByLogin(login);
            var hashCode = user.Password;

            return (password.GetHashCode() == hashCode);
        }
    }
}
