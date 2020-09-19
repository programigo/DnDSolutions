using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Animals
{
    public class Livestock : DeliveryItem
    {
        [Required]
        public string Breed { get; set; }

        [Required]
        public int TotalWeight { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public bool HasAllVaccinations { get; set; }

        [Required]
        public bool HasAllTags { get; set; }

        [Required]
        public bool HasSpecificNeeds { get; set; }

        public bool IsInCorral { get; set; }
    }
}
