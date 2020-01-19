using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class StepsRepository : BaseRepository<Steps>, IStepsRepository
    {
        public StepsRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
