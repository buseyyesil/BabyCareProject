using BabyCareProject.Dtos.BannerDtos;

namespace BabyCareProject.Services.BannerServices
{
    public interface IBannerService
    {
        Task<List<ResultBannerDto>> GetAllBannerAsync();

        Task<List<ResultBannerDto>> GetActiveBannersAsync();

        Task<UpdateBannerDto> GetBannerByIdAsync(string id);

        Task CreateBannerAsync(CreateBannerDto createBannerDto);

        Task UpdateBannerAsync(UpdateBannerDto updateBannerDto);

        Task DeleteBannerAsync(string id);
    }
}