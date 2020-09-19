namespace DnDSolutions.Web.Models.Animals
{
    public class CatDetailsViewModel : DeliveryViewModel
	{
        public int Count { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Weight { get; set; }

        public bool HasAllVaccinations { get; set; }

        public bool HasCarrier { get; set; }

        public bool HasSpecificNeeds { get; set; }
    }
}
