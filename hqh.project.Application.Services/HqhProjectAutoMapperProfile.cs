using AutoMapper;
using hqh.project.Common;
using hqh.project.Dtos;
using hqh.project.EntityFrameCore;

namespace hqh.project.Application.Services
{
    public class HqhProjectAutoMapperProfile : Profile,IProfile
    {
        public HqhProjectAutoMapperProfile()
        {
            CreateMap<AddEditUserDto, User>();
        }
    }
}
