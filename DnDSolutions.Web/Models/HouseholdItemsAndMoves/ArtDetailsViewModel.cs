using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
	public class ArtDetailsViewModel : DeliveryViewModel
	{
		public ArtType Type { get; set; }

		public string Description { get; set; }

		public string Packaging { get; set; }

		public string SpecialHandling { get; set; }

		public MeasurementUnit MeasurementUnit { get; set; }

		public int LengthFirstPart { get; set; }

		public int? LengthSecondPart { get; set; }

		public int WidthFirstPart { get; set; }

		public int? WidthSecondPart { get; set; }

		public int HeightFirstPart { get; set; }

		public int? HeightSecondPart { get; set; }

		public int Weight { get; set; }
	}
}
