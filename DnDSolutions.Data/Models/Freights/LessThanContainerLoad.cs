using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Freights
{
    public class LessThanContainerLoad : DeliveryItem, IMeasurable
    {
        [Required]
        public LessThanContainerLoadType Type { get; set; }

        [Required]
        public HandlingUnitType HandlingUnit { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }

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

        [Required]
        public int Quantity { get; set; }

        public bool IsStackable { get; set; }

        public bool IsHazardous { get; set; }
    }
}
