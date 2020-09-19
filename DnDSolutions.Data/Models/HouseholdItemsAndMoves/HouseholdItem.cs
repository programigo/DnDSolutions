using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public class HouseholdItem : DeliveryItem, IMeasurable
    {
        [Required]
        public int NumberOfItems { get; set; }

        [Required]
        public HouseholdItemType Type { get; set; }

        [Required]
        public bool IsPalletised { get; set; }

        [Required]
        public bool IsCrated { get; set; }

        [Required]
        public bool IsStickable { get; set; }

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
