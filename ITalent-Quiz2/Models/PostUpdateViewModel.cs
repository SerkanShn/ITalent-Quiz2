namespace ITalent_Quiz2.Models
{
    public class PostUpdateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string PostBanner { get; set; }
        public string PostContents { get; set; }
        public DateTime EditedOn { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
    }
}
