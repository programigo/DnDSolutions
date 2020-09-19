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
        [Display(Name = "Collection Date Earliest")]
        public DateTime CollectionDateEarliest { get; set; }

        [Required]
        [Display(Name = "Collection Date Latest")]
        public DateTime CollectionDateLatest { get; set; }

        [Required]
        [Display(Name = "Delivery Date Earliest")]
        public DateTime DeliveryDateEarliest { get; set; }

        [Required]
        [Display(Name = "Delivery Date Latest")]
        public DateTime DeliveryDateLatest { get; set; }

        public List<IFormFile> Photos { get; set; }

        [Display(Name = "Additional Details")]
        public string AdditionalDetails { get; set; }
    }
}
