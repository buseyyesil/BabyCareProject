namespace BabyCareProject.Dtos.BannerDtos
{
    public class UpdateBannerDto
    {
        public string BannerId { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }

        public string ButtonText { get; set; }

        public string ButtonUrl { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; }
    }
}
