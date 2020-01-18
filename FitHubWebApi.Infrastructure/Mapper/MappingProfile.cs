using AutoMapper;
using Dom = FitHubWebApi.Core.Domain;
using Db = FitHubWebApi.Infrastructure.Models;

namespace FitHubWebApi.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Db.Users, Dom.User>();
            CreateMap<Dom.User, Db.Users>();
        }
    }
}
