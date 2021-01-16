using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models
{
    public class DeliveryFormModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Pickup Location")]
        public string PickupLocation { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Delivery Location")]
        public string DeliveryLocation { get; set; }

        [Required]
        [Display(Name = "Collection Date")]
        public DateTime CollectionDate { get; set; }

        [Required]
        [Display(Name = "Delivery Date")]
        public DateTime DeliveryDate { get; set; }

        public List<IFormFile> Photos { get; set; }

        [Display(Name = "Additional Details")]
        public string AdditionalDetails { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Insurance")]
        public bool HasInsurance { get; set; }
    }
}
