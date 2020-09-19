using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class Motorcycle : DeliveryItem
    {
        public MotorcycleType Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        public MotorcycleState State { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}
