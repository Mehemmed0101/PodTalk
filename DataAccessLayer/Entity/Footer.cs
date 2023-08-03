namespace PodTalk.DataAccessLayer.Entity
{
    public class Footer
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string ImgUrl { get; set; }
        public string DesignedBy { get; set; }
        public ICollection<SocialMedia> SocialMedia { get; set; }
    }
}