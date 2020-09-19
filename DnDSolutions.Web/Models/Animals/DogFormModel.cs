using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Animals
{
    public class DogFormModel : DeliveryFormModel
    {
        [Required]
        public int Count { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        [Display(Name = "Has All Vaccinations")]
        public bool HasAllVaccinations { get; set; }

        [Required]
        [Display(Name = "Has Carrier")]
        public bool HasCarrier { get; set; }

        [Required]
        [Display(Name = "Has Specific Needs")]
        public bool HasSpecificNeeds { get; set; }
    }
}
