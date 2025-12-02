using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.FooterDtos.FooterSubscribeDtos;
using MongoDB.Driver;

namespace BabyCareProject.Services.FooterServices.FooterSubscribeServices
{
    public class FooterSubscribeService : IFooterSubscribeService
    {
        private readonly IMongoCollection<FooterSubscribe> _footerSubscribeCollection;
        private readonly IMapper _mapper;

        public FooterSubscribeService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _footerSubscribeCollection = database.GetCollection<FooterSubscribe>(databaseSettings.FooterSubscribeCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultFooterSubscribeDto>> GetAllFooterSubscribeAsync()
        {
            var values = await _footerSubscribeCollection.Find(x => true).SortByDescending(x => x.SubscribeDate).ToListAsync();
            return _mapper.Map<List<ResultFooterSubscribeDto>>(values);
        }

        public async Task<List<ResultFooterSubscribeDto>> GetActiveSubscribersAsync()
        {
            var values = await _footerSubscribeCollection
                .Find(x => x.IsActive == true)
                .SortByDescending(x => x.SubscribeDate)
                .ToListAsync();
            return _mapper.Map<List<ResultFooterSubscribeDto>>(values);
        }

        public async Task<ResultFooterSubscribeDto> GetFooterSubscribeByIdAsync(string id)
        {
            var value = await _footerSubscribeCollection.Find(x => x.FooterSubscribeId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultFooterSubscribeDto>(value);
        }

        public async Task CreateFooterSubscribeAsync(CreateFooterSubscribeDto createFooterSubscribeDto)
        {
            var value = _mapper.Map<FooterSubscribe>(createFooterSubscribeDto);
            await _footerSubscribeCollection.InsertOneAsync(value);
        }

        public async Task UpdateFooterSubscribeAsync(UpdateFooterSubscribeDto updateFooterSubscribeDto)
        {
            var value = _mapper.Map<FooterSubscribe>(updateFooterSubscribeDto);
            await _footerSubscribeCollection.FindOneAndReplaceAsync(x => x.FooterSubscribeId == updateFooterSubscribeDto.FooterSubscribeId, value);
        }

        public async Task DeleteFooterSubscribeAsync(string id)
        {
            await _footerSubscribeCollection.DeleteOneAsync(x => x.FooterSubscribeId == id);
        }
    }
}