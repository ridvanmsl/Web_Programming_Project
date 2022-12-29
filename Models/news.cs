using System.ComponentModel.DataAnnotations;

namespace WebAssignment.Models
{
    public class news
    {
        [Key]
        public int Id { get; set; }

        public string? news_date { get; set; }
        public string? news_category { get; set; }
        public string? news_img { get; set; }
        public string? news_text { get; set; }
    }
}
