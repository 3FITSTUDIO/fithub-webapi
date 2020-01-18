using FitHubWebApi.Core.Domain;
using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.DbContext;
using FitHubWebApi.Infrastructure.Repositories.Base;

namespace FitHubWebApi.Infrastructure.Repositories
{
    public class MeasurementRepository : BaseRepository<Measurement>, IMeasurementRepository
    {
        public MeasurementRepository(FitHubWebApiContext context) : base(context)
        {
        }
    }
}
