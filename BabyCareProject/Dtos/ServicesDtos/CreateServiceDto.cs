namespace BabyCareProject.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}