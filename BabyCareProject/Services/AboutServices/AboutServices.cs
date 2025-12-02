using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Services.AboutServices;
using MongoDB.Driver;

namespace BabyCareProject.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly IMongoCollection<About> _aboutCollection;
        private readonly IMapper _mapper;

        public AboutService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _aboutCollection = database.GetCollection<About>(databaseSettings.AboutCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultAboutDto>> GetAllAboutAsync()
        {
            var values = await _aboutCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultAboutDto>>(values);
        }

        public async Task<ResultAboutDto> GetAboutAsync()
        {
            var value = await _aboutCollection.Find(x => true).FirstOrDefaultAsync();
            return _mapper.Map<ResultAboutDto>(value);
        }

        public async Task<ResultAboutDto> GetAboutByIdAsync(string id)
        {
            var value = await _aboutCollection.Find(x => x.AboutId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultAboutDto>(value);
        }

        public async Task CreateAboutAsync(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<About>(createAboutDto);
            await _aboutCollection.InsertOneAsync(value);
        }

        public async Task UpdateAboutAsync(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            await _aboutCollection.FindOneAndReplaceAsync(x => x.AboutId == updateAboutDto.AboutId, value);
        }

        public async Task DeleteAboutAsync(string id)
        {
            await _aboutCollection.DeleteOneAsync(x => x.AboutId == id);
        }
    }
}
