using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.FooterDtos.FooterInformationDtos;
using BabyCareProject.Services.FooterServices.FooterInformationServices;
using MongoDB.Driver;

namespace BabyCareProject.Services.FooterServices.FooterInformationServices
{
    public class FooterInformationService : IFooterInformationService
    {
        private readonly IMongoCollection<FooterInformation> _footerInformationCollection;
        private readonly IMapper _mapper;

        public FooterInformationService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _footerInformationCollection = database.GetCollection<FooterInformation>(databaseSettings.FooterInformationCollectionName);
            _mapper = mapper;
        }

        public async Task<ResultFooterInformationDto> GetFooterInformationAsync()
        {
            var value = await _footerInformationCollection.Find(x => true).FirstOrDefaultAsync();
            return _mapper.Map<ResultFooterInformationDto>(value);
        }

        public async Task<ResultFooterInformationDto> GetFooterInformationByIdAsync(string id)
        {
            var value = await _footerInformationCollection.Find(x => x.FooterInformationId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultFooterInformationDto>(value);
        }

        public async Task CreateFooterInformationAsync(CreateFooterInformationDto createFooterInformationDto)
        {
            var value = _mapper.Map<FooterInformation>(createFooterInformationDto);
            await _footerInformationCollection.InsertOneAsync(value);
        }

        public async Task UpdateFooterInformationAsync(UpdateFooterInformationDto updateFooterInformationDto)
        {
            var value = _mapper.Map<FooterInformation>(updateFooterInformationDto);
            await _footerInformationCollection.FindOneAndReplaceAsync(x => x.FooterInformationId == updateFooterInformationDto.FooterInformationId, value);
        }

        public async Task DeleteFooterInformationAsync(string id)
        {
            await _footerInformationCollection.DeleteOneAsync(x => x.FooterInformationId == id);
        }
    }
}