using BabyCareProject.Dtos.FooterDtos.FooterInformationDtos;

namespace BabyCareProject.Services.FooterServices.FooterInformationServices
{
    public interface IFooterInformationService
    {
        Task<ResultFooterInformationDto> GetFooterInformationAsync();
        Task<ResultFooterInformationDto> GetFooterInformationByIdAsync(string id);
        Task CreateFooterInformationAsync(CreateFooterInformationDto createFooterInformationDto);
        Task UpdateFooterInformationAsync(UpdateFooterInformationDto updateFooterInformationDto);
        Task DeleteFooterInformationAsync(string id);
    }
}