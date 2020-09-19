using DnDSolutions.Data.Models.Animals;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Animals
{
    public class HorseFormModel : DeliveryFormModel
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
