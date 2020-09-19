using DnDSolutions.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Vehicles
{
    public class CarFormModel : DeliveryFormModel
    {
        [Display(Name = "Body Type")]
        public CarBodyType BodyType { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Display(Name = "Car State")]
        public IEnumerable<CarState> State { get; set; }

        [Display(Name = "Service Type")]
        public ServiceType ServiceType { get; set; }
    }
}
