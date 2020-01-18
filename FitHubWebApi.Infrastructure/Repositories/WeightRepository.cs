using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class WeightRepository : BaseRepository<Weight>, IWeightRepository
    {
        public WeightRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
