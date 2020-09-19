using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class RecreationalVehicle : DeliveryItem, IMeasurable
    {
        public CamperType Type { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }

        [Required]
        public int LengthFirstPart { get; set; }

        [Required]
        public int? LengthSecondPart { get; set; }

        [Required]
        public int WidthFirstPart { get; set; }

        [Required]
        public int? WidthSecondPart { get; set; }

        [Required]
        public int HeightFirstPart { get; set; }

        [Required]
        public int? HeightSecondPart { get; set; }

        [Required]
        public int Weight { get; set; }

        public bool? CanBeDriven { get; set; }

        public string Description { get; set; }

        [MinLength(10)]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }
    }
}
