using FitHubWebApi.Core.DTO;
using FitHubWebApi.Infrastructure.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitHubWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public async Task Create([FromBody] UserDTO user)
        {
            await _usersService.Add(user);
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _usersService.GetById(id);
        }

        [HttpGet("{login}, {password}")]
        public async Task<bool> IsPasswordValid(string login, string password)
        {
            return await _usersService.IsPasswordValid(login, password);
        }

        [HttpPut("{id}")]
        public async Task Update([FromBody] UserDTO user)
        {
            await _usersService.Update(user);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _usersService.Delete(id);
        }
    }
}