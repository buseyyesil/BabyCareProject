using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.FooterDtos.FooterGalleryDtos;

namespace BabyCareProject.Mappings
{
    public class FooterGalleryMapping : Profile
    {
        public FooterGalleryMapping()
        {
            CreateMap<FooterGallery, ResultFooterGalleryDto>().ReverseMap();
            CreateMap<FooterGallery, CreateFooterGalleryDto>().ReverseMap();
            CreateMap<FooterGallery, UpdateFooterGalleryDto>().ReverseMap();
        }
    }
}