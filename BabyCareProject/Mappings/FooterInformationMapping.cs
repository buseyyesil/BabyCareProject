using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.FooterDtos.FooterInformationDtos;

namespace BabyCareProject.Mappings
{
    public class FooterInformationMapping : Profile
    {
        public FooterInformationMapping()
        {
            CreateMap<FooterInformation, ResultFooterInformationDto>().ReverseMap();
            CreateMap<FooterInformation, CreateFooterInformationDto>().ReverseMap();
            CreateMap<FooterInformation, UpdateFooterInformationDto>().ReverseMap();
        }
    }
}