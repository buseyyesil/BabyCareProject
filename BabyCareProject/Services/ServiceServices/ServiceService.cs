using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Services.ServiceServices;
using MongoDB.Driver;

namespace BabyCareProject.Services.ServiceServices
{
    public class ServiceService : IServiceService
    {
        private readonly IMongoCollection<Service> _serviceCollection;
        private readonly IMapper _mapper;

        public ServiceService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _serviceCollection = database.GetCollection<Service>(databaseSettings.ServiceCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            var values = await _serviceCollection.Find(x => true).SortBy(x => x.Order).ToListAsync();
            return _mapper.Map<List<ResultServiceDto>>(values);
        }

        public async Task<List<ResultServiceDto>> GetActiveServicesAsync()
        {
            var values = await _serviceCollection.Find(x => x.IsActive == true).SortBy(x => x.Order).ToListAsync();
            return _mapper.Map<List<ResultServiceDto>>(values);
        }

        public async Task<ResultServiceDto> GetServiceByIdAsync(string id)
        {
            var value = await _serviceCollection.Find(x => x.ServiceId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultServiceDto>(value);
        }

        public async Task CreateServiceAsync(CreateServiceDto createServiceDto)
        {
            var value = _mapper.Map<Service>(createServiceDto);
            await _serviceCollection.InsertOneAsync(value);
        }

        public async Task UpdateServiceAsync(UpdateServiceDto updateServiceDto)
        {
            var value = _mapper.Map<Service>(updateServiceDto);
            await _serviceCollection.FindOneAndReplaceAsync(x => x.ServiceId == updateServiceDto.ServiceId, value);
        }

        public async Task DeleteServiceAsync(string id)
        {
            await _serviceCollection.DeleteOneAsync(x => x.ServiceId == id);
        }
    }
}