namespace DnDSolutions.Web.Models.Animals
{
	public class LivestockDetailsViewModel : DeliveryViewModel
	{
		public string Breed { get; set; }

		public int TotalWeight { get; set; }

		public int Count { get; set; }

		public bool HasAllVaccinations { get; set; }

		public bool HasAllTags { get; set; }

		public bool HasSpecificNeeds { get; set; }

		public bool IsInCorral { get; set; }
	}
}
