using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class ATV : DeliveryItem, IMeasurable
    {
        [Required]
        public string ItemDescription { get; set; }

        [Required]
        public int LengthFirstPart { get; set; }

        public int? LengthSecondPart { get; set; }

        [Required]
        public int WidthFirstPart { get; set; }

        public int? WidthSecondPart { get; set; }

        [Required]
        public int HeightFirstPart { get; set; }

        public int? HeightSecondPart { get; set; }

        [Required]
        public int Weight { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }
    }
}
