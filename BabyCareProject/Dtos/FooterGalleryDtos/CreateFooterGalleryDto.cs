namespace BabyCareProject.Dtos.FooterDtos.FooterGalleryDtos
{
    public class CreateFooterGalleryDto
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}