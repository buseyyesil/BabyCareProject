using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.BannerDtos;

namespace BabyCareProject.Mappings
{
    public class BannerMapping : Profile
    {
        public BannerMapping()  
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();
            CreateMap<Banner, CreateBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();
        }
    }
}