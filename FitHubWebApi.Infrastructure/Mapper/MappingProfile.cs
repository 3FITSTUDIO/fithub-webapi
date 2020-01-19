using AutoMapper;
using Dom = FitHubWebApi.Core.Domain;
using Db = FitHubWebApi.Infrastructure.Models;

namespace FitHubWebApi.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Db.User, Dom.User>();
            CreateMap<Dom.User, Db.User>();
        }
    }
}
