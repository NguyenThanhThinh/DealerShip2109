using System.ComponentModel.DataAnnotations;

namespace DealerShip2109.Data
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }
    }
}
