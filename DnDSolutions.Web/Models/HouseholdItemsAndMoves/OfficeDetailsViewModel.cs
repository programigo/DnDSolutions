namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
	public class OfficeDetailsViewModel : DeliveryViewModel
	{
		public int CollectionFloor { get; set; }

		public bool HasCollectionFloorElevator { get; set; }

		public int DeliveryFloor { get; set; }

		public bool HasDeliveryFloorElevator { get; set; }

		public bool HasDisassemblyItems { get; set; }

		public bool HasReassemblyItems { get; set; }
	}
}
