using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title can't be null or empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Director can't be null or empty")]
        public string Director { get; set; }
        public string Genre { get; set; }
        [Range(60, 600, ErrorMessage = "Duration can't be less than 60 and can't be more than 600 minutes")]
        public int Duration { get; set; }
    }
}
