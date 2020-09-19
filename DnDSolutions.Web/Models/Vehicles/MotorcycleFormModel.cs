using DnDSolutions.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Vehicles
{
    public class MotorcycleFormModel : DeliveryFormModel
    {
        [Display(Name = "Motorcycle Type")]
        public MotorcycleType Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Display(Name = "Motorcycle State")]
        public IEnumerable<MotorcycleState> State { get; set; }

        [Display(Name = "Service Type")]
        public ServiceType ServiceType { get; set; }
    }
}
