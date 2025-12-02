using BabyCareProject.Dtos.EventDtos;

namespace BabyCareProject.Services.EventServices
{
    public interface IEventService
    {
        Task<List<ResultEventDto>> GetAllEventAsync();
        Task<List<ResultEventDto>> GetActiveEventsAsync();
        Task<ResultEventDto> GetEventByIdAsync(string id);
        Task CreateEventAsync(CreateEventDto createEventDto);
        Task UpdateEventAsync(UpdateEventDto updateEventDto);
        Task DeleteEventAsync(string id);
    }
}