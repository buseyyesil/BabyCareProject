namespace BabyCareProject.Dtos.FooterDtos.FooterSubscribeDtos
{
    public class UpdateFooterSubscribeDto
    {
        public string FooterSubscribeId { get; set; }
        public string Email { get; set; }
        public DateTime SubscribeDate { get; set; }
        public bool IsActive { get; set; }
    }
}