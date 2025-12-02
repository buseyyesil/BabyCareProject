using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.FooterDtos.FooterSubscribeDtos;

namespace BabyCareProject.Mappings
{
    public class FooterSubscribeMapping : Profile
    {
        public FooterSubscribeMapping()
        {
            CreateMap<FooterSubscribe, ResultFooterSubscribeDto>().ReverseMap();
            CreateMap<FooterSubscribe, CreateFooterSubscribeDto>().ReverseMap();
            CreateMap<FooterSubscribe, UpdateFooterSubscribeDto>().ReverseMap();
        }
    }
}