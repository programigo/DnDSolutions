using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Animals
{
    public class Cat : DeliveryItem, ISmallMammal
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
        public bool HasAllVaccinations { get; set; }

        [Required]
        public bool HasCarrier { get; set; }

        [Required]
        public bool HasSpecificNeeds { get; set; }
    }
}
