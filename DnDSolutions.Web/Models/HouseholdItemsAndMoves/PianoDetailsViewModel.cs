using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
	public class PianoDetailsViewModel : DeliveryViewModel
	{
		public PianoType Type { get; set; }

		public VerticalPianoType VerticalType { get; set; }

		public HorizontalPianoType HorizontalType { get; set; }

		public bool? IsOnCasters { get; set; }
	}
}
