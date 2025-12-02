using BabyCareProject.Dtos.ServiceDtos;

namespace BabyCareProject.Services.ServiceServices
{
    public interface IServiceService
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task<List<ResultServiceDto>> GetActiveServicesAsync();
        Task<ResultServiceDto> GetServiceByIdAsync(string id);
        Task CreateServiceAsync(CreateServiceDto createServiceDto);
        Task UpdateServiceAsync(UpdateServiceDto updateServiceDto);
        Task DeleteServiceAsync(string id);
    }
}