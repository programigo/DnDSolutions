using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
    public class HouseholdItemFormModel : DeliveryFormModel, IMeasurable
	{
        [Required]
        [Display(Name = "Number Of Items")]
        public int NumberOfItems { get; set; }

        [Required]
        public HouseholdItemType Type { get; set; }

        [Required]
        [Display(Name = "Is Palletised")]
        public bool IsPalletised { get; set; }

        [Required]
        [Display(Name = "Is Crated")]
        public bool IsCrated { get; set; }

        [Required]
        [Display(Name = "Is Stickable")]
        public bool IsStickable { get; set; }

        [Display(Name = "Measurement Unit")]
        public MeasurementUnit MeasurementUnit { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int LengthFirstPart { get; set; }

        public int? LengthSecondPart { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int WidthFirstPart { get; set; }

        public int? WidthSecondPart { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int HeightFirstPart { get; set; }

        public int? HeightSecondPart { get; set; }

        [Required]
        public int Weight { get; set; }
    }
}
