using BabyCareProject.Dtos.FooterDtos.FooterSubscribeDtos;

namespace BabyCareProject.Services.FooterServices.FooterSubscribeServices
{
    public interface IFooterSubscribeService
    {
        Task<List<ResultFooterSubscribeDto>> GetAllFooterSubscribeAsync();
        Task<List<ResultFooterSubscribeDto>> GetActiveSubscribersAsync();
        Task<ResultFooterSubscribeDto> GetFooterSubscribeByIdAsync(string id);
        Task CreateFooterSubscribeAsync(CreateFooterSubscribeDto createFooterSubscribeDto);  // ✅ Task (void return)
        Task UpdateFooterSubscribeAsync(UpdateFooterSubscribeDto updateFooterSubscribeDto);
        Task DeleteFooterSubscribeAsync(string id);
    }
}