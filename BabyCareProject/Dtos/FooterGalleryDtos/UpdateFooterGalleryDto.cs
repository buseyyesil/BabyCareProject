namespace BabyCareProject.Dtos.FooterDtos.FooterGalleryDtos
{
    public class UpdateFooterGalleryDto
    {
        public string FooterGalleryId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}