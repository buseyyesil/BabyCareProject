using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.FooterDtos.FooterGalleryDtos;
using BabyCareProject.Services.FooterServices.FooterGalleryServices;
using MongoDB.Driver;

namespace BabyCareProject.Services.FooterServices.FooterGalleryServices
{
    public class FooterGalleryService : IFooterGalleryService
    {
        private readonly IMongoCollection<FooterGallery> _footerGalleryCollection;
        private readonly IMapper _mapper;

        public FooterGalleryService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _footerGalleryCollection = database.GetCollection<FooterGallery>(databaseSettings.FooterGalleryCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultFooterGalleryDto>> GetAllFooterGalleryAsync()
        {
            var values = await _footerGalleryCollection.Find(x => true).SortBy(x => x.Order).ToListAsync();
            return _mapper.Map<List<ResultFooterGalleryDto>>(values);
        }

        public async Task<List<ResultFooterGalleryDto>> GetActiveFooterGalleriesAsync()
        {
            var values = await _footerGalleryCollection
                .Find(x => x.IsActive == true)
                .SortBy(x => x.Order)
                .ToListAsync();
            return _mapper.Map<List<ResultFooterGalleryDto>>(values);
        }

        public async Task<ResultFooterGalleryDto> GetFooterGalleryByIdAsync(string id)
        {
            var value = await _footerGalleryCollection.Find(x => x.FooterGalleryId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultFooterGalleryDto>(value);
        }

        public async Task CreateFooterGalleryAsync(CreateFooterGalleryDto createFooterGalleryDto)
        {
            var value = _mapper.Map<FooterGallery>(createFooterGalleryDto);
            await _footerGalleryCollection.InsertOneAsync(value);
        }

        public async Task UpdateFooterGalleryAsync(UpdateFooterGalleryDto updateFooterGalleryDto)
        {
            var value = _mapper.Map<FooterGallery>(updateFooterGalleryDto);
            await _footerGalleryCollection.FindOneAndReplaceAsync(x => x.FooterGalleryId == updateFooterGalleryDto.FooterGalleryId, value);
        }

        public async Task DeleteFooterGalleryAsync(string id)
        {
            await _footerGalleryCollection.DeleteOneAsync(x => x.FooterGalleryId == id);
        }
    }
}