using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.TestimonialServices;
using MongoDB.Driver;

namespace BabyCareProject.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Testimonial> _testimonialCollection;
        private readonly IMapper _mapper;

        public TestimonialService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _testimonialCollection = database.GetCollection<Testimonial>(databaseSettings.TestimonialCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            var values = await _testimonialCollection.Find(x => true).SortBy(x => x.Order).ToListAsync();
            return _mapper.Map<List<ResultTestimonialDto>>(values);
        }

        public async Task<List<ResultTestimonialDto>> GetActiveTestimonialsAsync()
        {
            var values = await _testimonialCollection
                .Find(x => x.IsActive == true)
                .SortBy(x => x.Order)
                .ToListAsync();
            return _mapper.Map<List<ResultTestimonialDto>>(values);
        }

        public async Task<ResultTestimonialDto> GetTestimonialByIdAsync(string id)
        {
            var value = await _testimonialCollection.Find(x => x.TestimonialId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultTestimonialDto>(value);
        }

        public async Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
            await _testimonialCollection.InsertOneAsync(value);
        }

        public async Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            await _testimonialCollection.FindOneAndReplaceAsync(x => x.TestimonialId == updateTestimonialDto.TestimonialId, value);
        }

        public async Task DeleteTestimonialAsync(string id)
        {
            await _testimonialCollection.DeleteOneAsync(x => x.TestimonialId == id);
        }
    }
}