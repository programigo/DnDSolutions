using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
    public class ArtFormModel : DeliveryFormModel, IMeasurable
    {
        [Required]
        public ArtType Type { get; set; }

        public string Description { get; set; }

        public string Packaging { get; set; }

        [Display(Name = "Special Handling")]
        public string SpecialHandling { get; set; }

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
