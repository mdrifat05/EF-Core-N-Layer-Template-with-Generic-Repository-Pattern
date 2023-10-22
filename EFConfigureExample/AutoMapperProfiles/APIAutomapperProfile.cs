using AutoMapper;
using EFConfigureExample.DataAccessLayer.Models;
using EFConfigureExample.DTOs;

namespace EFConfigureExample.AutoMapperProfiles
{
    public class APIAutomapperProfile : Profile
    {
        public APIAutomapperProfile()
        {
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
