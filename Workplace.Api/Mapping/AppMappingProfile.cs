using AutoMapper;
using Workplace.Application.Commands;
using Workplace.Application.Queries;
using Workplace.Application.Services.Common;
using Workplace.Contracts.Requests;
using Workplace.Contracts.Responses;

namespace Workplace.Api.Mapping
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<ListResult, ListResponse>();
            CreateMap<GetRequest, GetQuery>();
            CreateMap<GetResult, GetResponse>()
                .ForMember(dest => dest.NickName, opt => opt.MapFrom(src => src.User.NickName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.User.Comments))
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.User.CreateDate));
            CreateMap<CreateRequest, CreateCommand>();
            CreateMap<CreateResult, CreateResponse>();
            CreateMap<DeleteRequest, DeleteCommand>();
            CreateMap<DeleteResult, DeleteResponse>();
            CreateMap<UpdateRequest, UpdateCommand>();
            CreateMap<UpdateResult, UpdateResponse>()
                .ForMember(dest => dest.NickName, opt => opt.MapFrom(src => src.User.NickName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.User.Comments));
        }
    }
}
