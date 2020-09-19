using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Animals
{
    public class Horse : DeliveryItem
    {
        [Required]
        public int Count { get; set; }

        [Required]
        public HorseBreed Breed { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
