using System.ComponentModel.DataAnnotations;

namespace TrackCalories.Models
{
    public class Calories
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        [Required]
        public string? Description {  get; set; }

    }
}
