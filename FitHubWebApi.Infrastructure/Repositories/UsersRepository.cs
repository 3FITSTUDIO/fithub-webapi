using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class UsersRepository : BaseRepository<User>, IUsersRepository
    {
        public UsersRepository(FitHubWebApiContext context) : base(context)
        {
        }

        public async Task<int> GetUsersPasswordHashCode(string login)
        {
            var hashCode = await Table
                .Include(z => z.Password)
                .Where(x => x.Login == login)
                .FirstOrDefaultAsync();

            return hashCode.Password.HashValue;
        }

        public async Task<User> GetByLogin(string login)
        {
            var userByLogin = await Table.FirstOrDefaultAsync(l => l.Login.Equals(login));

            return userByLogin;
        }
    }
}
