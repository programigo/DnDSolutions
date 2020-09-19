using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public class Art : DeliveryItem, IMeasurable
    {
        [Required]
        public ArtType Type { get; set; }

        public string Description { get; set; }

        public string Packaging { get; set; }

        public string SpecialHandling { get; set; }

        [Required]
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
    }
}
