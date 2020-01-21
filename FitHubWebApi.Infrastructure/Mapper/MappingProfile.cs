using AutoMapper;
using Dom = FitHubWebApi.Core.Domain;
using Db = FitHubWebApi.Infrastructure.Models;
using Dto = FitHubWebApi.Core.DTO;

namespace FitHubWebApi.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Db.User, Dom.User>();
            CreateMap<Dom.User, Db.User>();
            CreateMap<Dto.UserDTO, Db.User>();
            CreateMap<Dto.UserDTO, Dom.User>();
            CreateMap<Dom.User, Dto.UserDTO>();
            CreateMap<Db.User, Dto.UserDTO>();

        }
    }
}
