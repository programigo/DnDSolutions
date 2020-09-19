using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Vehicles
{
    public class RecreationalVehicleFormModel : DeliveryFormModel, IMeasurable
    {
        public CamperType Type { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [Display(Name = "Can Be Driven")]
        public bool? CanBeDriven { get; set; }

        [Required]
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
