using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class HeightRepository : BaseRepository<Height>, IHeightRepository
    {
        public HeightRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
