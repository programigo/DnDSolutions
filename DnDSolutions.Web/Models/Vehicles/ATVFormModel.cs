using DnDSolutions.Data;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Vehicles
{
    public class ATVFormModel : DeliveryFormModel, IMeasurable
    {
        [Required]
        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }

        [Required]
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
