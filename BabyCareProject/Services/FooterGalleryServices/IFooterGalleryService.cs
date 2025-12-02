using BabyCareProject.Dtos.FooterDtos.FooterGalleryDtos;

namespace BabyCareProject.Services.FooterServices.FooterGalleryServices
{
    public interface IFooterGalleryService
    {
        Task<List<ResultFooterGalleryDto>> GetAllFooterGalleryAsync();
        Task<List<ResultFooterGalleryDto>> GetActiveFooterGalleriesAsync();
        Task<ResultFooterGalleryDto> GetFooterGalleryByIdAsync(string id);
        Task CreateFooterGalleryAsync(CreateFooterGalleryDto createFooterGalleryDto);
        Task UpdateFooterGalleryAsync(UpdateFooterGalleryDto updateFooterGalleryDto);
        Task DeleteFooterGalleryAsync(string id);
    }
}