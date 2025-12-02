using BabyCareProject.Dtos.InstructorDtos;

namespace BabyCareProject.Services.InstructorServices
{
    public interface IInstructorService
    {

        Task<List<ResultInstructorDto>> GetAllInstructorAsync();

        Task<UpdateInstructorDto> GetInstructorByIdAsync(string id); // idleri string formatta tuttuğumuz için string id olacak

        Task CreateInstructorAsync(CreateInstructorDto createInstructorDto);

        Task UpdateInstructorAsync(UpdateInstructorDto updateInstructorDto);

        Task DeleteInstructorAsync(string id);

    }
}
