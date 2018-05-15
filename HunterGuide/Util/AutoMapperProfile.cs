using AutoMapper;
using HunterGuide.EF.Entities;
using HunterGuide.Models;

namespace HunterGuide.Util {
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile() 
        {
            CreateMap<RegistrationModel, ApplicationUser>()
               .ForMember(au => au.PasswordHash, opt => opt.MapFrom(src => src.Password))
               .ReverseMap();
        }
    }
}
