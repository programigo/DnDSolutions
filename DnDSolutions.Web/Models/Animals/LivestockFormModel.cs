using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Animals
{
    public class LivestockFormModel : DeliveryFormModel
    {
        [Required]
        public string Breed { get; set; }

        [Required]
        [Display(Name = "Total Weight")]
        public int TotalWeight { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        [Display(Name = "Has All Vaccinations")]
        public bool HasAllVaccinations { get; set; }

        [Required]
        [Display(Name = "Has All Tags")]
        public bool HasAllTags { get; set; }

        [Required]
        [Display(Name = "Has Specific Needs")]
        public bool HasSpecificNeeds { get; set; }

        [Display(Name = "Is In Corral")]
        public bool IsInCorral { get; set; }
    }
}
