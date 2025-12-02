using BabyCareProject.Dtos.AboutDtos;

namespace BabyCareProject.Dtos.AboutDtos
{
    public class UpdateAboutDto
    {
        public string AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public int YearsOfExperience { get; set; }
        public int HappyChildren { get; set; }
        public int QualifiedTeachers { get; set; }
        public int ActivePrograms { get; set; }
    }
}
