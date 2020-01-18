using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class LogsRepository : BaseRepository<Log>, ILogsRepository
    {
        public LogsRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
