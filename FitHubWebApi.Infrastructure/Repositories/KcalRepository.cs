using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class KcalRepository : BaseRepository<Kcal>, IKcalRepository
    {
        public KcalRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
