using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<UserForListDto, User>();
        }
    }
}
