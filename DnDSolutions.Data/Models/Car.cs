using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class Car : DeliveryItem
    {
        public CarBodyType BodyType { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        public CarState State { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}
