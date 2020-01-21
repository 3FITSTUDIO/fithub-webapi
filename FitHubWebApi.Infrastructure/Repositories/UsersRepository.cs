using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class UsersRepository : BaseRepository<User>, IUsersRepository
    {
        public UsersRepository(FitHubWebApiContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email)
        {
            return await Table.FirstOrDefaultAsync(e => e.Email.Equals(email));
        }

        public async Task<User> GetByLogin(string login)
        {
            return await Table.FirstOrDefaultAsync(l => l.Login.Equals(login));
        }
    }
}
