using DnDSolutions.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Vehicles
{
    public class HeavyVehicleFormModel : DeliveryFormModel
    {
        [Required]
        public HeavyVehicleType Type { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Is it already on trailer?")]
        public bool IsOnTrailer { get; set; }

        [Required]
        [Display(Name = "What type of truck trailer?")]
        public HeavyVehicleOwnedTrailerType OwnedTrailerType { get; set; }

        [Required]
        [Display(Name = "Preferred trailer type")]
        public IEnumerable<HeavyVehicleTrailerType> TrailerType { get; set; }
    }
}
