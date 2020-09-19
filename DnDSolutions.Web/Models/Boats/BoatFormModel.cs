using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Boats
{
    public class BoatFormModel : DeliveryFormModel, IMeasurable
    {
        public BoatType Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Is it already on trailer?")]
        public bool IsOnTrailer { get; set; }

        [Required]
        [Display(Name = "Service Type")]
        public IEnumerable<BoatServiceType> ServiceType { get; set; }

        public string Description { get; set; }

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
