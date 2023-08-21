using AutoMapper;
using System;
using Workplace.Domain.User;
using Workplace.Infrastructure.Model;

namespace Workplace.Application.Mapping
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<UserEntity, User>().ReverseMap(); 
        }
    }
}
