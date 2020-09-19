using DnDSolutions.Data.Models.Animals;

namespace DnDSolutions.Web.Models.Animals
{
    public class HorseDetailsViewModel : DeliveryViewModel
	{
        public int Count { get; set; }

        public HorseBreed Breed { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public string Name { get; set; }
    }
}
