using BabyCareProject.Dtos.TestimonialDtos;

namespace BabyCareProject.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task<List<ResultTestimonialDto>> GetActiveTestimonialsAsync();
        Task<ResultTestimonialDto> GetTestimonialByIdAsync(string id);
        Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        Task DeleteTestimonialAsync(string id);
    }
}