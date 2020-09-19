using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class HeavyVehicle : DeliveryItem
    {
        [Required]
        public HeavyVehicleType Type { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public bool IsOnTrailer { get; set; }

        [Required]
        public HeavyVehicleOwnedTrailerType OwnedTrailerType { get; set; }

        [Required]
        public HeavyVehicleTrailerType TrailerType { get; set; }
    }
}
