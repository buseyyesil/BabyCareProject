namespace BabyCareProject.Dtos.FooterDtos.FooterSubscribeDtos
{
    public class CreateFooterSubscribeDto
    {
        public string Email { get; set; }
        public DateTime SubscribeDate { get; set; }
        public bool IsActive { get; set; }
    }
}