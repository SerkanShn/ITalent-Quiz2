namespace ITalent_Quiz2.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string PostBanner { get; set; }
        public string PostContents { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime EditedOn { get; set; }
        public Category Category { get; set; }
    }
}
