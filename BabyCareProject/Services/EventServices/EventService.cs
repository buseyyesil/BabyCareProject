using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Services.EventServices;
using MongoDB.Driver;

namespace BabyCareProject.Services.EventServices
{
    public class EventService : IEventService
    {
        private readonly IMongoCollection<Event> _eventCollection;
        private readonly IMapper _mapper;

        public EventService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _eventCollection = database.GetCollection<Event>(databaseSettings.EventCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultEventDto>> GetAllEventAsync()
        {
            var values = await _eventCollection.Find(x => true).SortBy(x => x.Order).ToListAsync();
            return _mapper.Map<List<ResultEventDto>>(values);
        }

        public async Task<List<ResultEventDto>> GetActiveEventsAsync()
        {
            var values = await _eventCollection
                .Find(x => x.IsActive == true)
                .SortBy(x => x.EventDate)
                .ToListAsync();
            return _mapper.Map<List<ResultEventDto>>(values);
        }

        public async Task<ResultEventDto> GetEventByIdAsync(string id)
        {
            var value = await _eventCollection.Find(x => x.EventId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultEventDto>(value);
        }

        public async Task CreateEventAsync(CreateEventDto createEventDto)
        {
            var value = _mapper.Map<Event>(createEventDto);
            await _eventCollection.InsertOneAsync(value);
        }

        public async Task UpdateEventAsync(UpdateEventDto updateEventDto)
        {
            var value = _mapper.Map<Event>(updateEventDto);
            await _eventCollection.FindOneAndReplaceAsync(x => x.EventId == updateEventDto.EventId, value);
        }

        public async Task DeleteEventAsync(string id)
        {
            await _eventCollection.DeleteOneAsync(x => x.EventId == id);
        }
    }
}