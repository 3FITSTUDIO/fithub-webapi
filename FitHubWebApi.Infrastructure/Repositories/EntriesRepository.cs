using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class EntriesRepository : BaseRepository<Entries>, IEntriesRepository
    {
        public EntriesRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
