using DnDSolutions.Data;

namespace DnDSolutions.Web.Models.Vehicles
{
	public class ATVDetailsViewModel : DeliveryViewModel
	{
		public string ItemDescription { get; set; }

		public int LengthFirstPart { get; set; }

		public int? LengthSecondPart { get; set; }

		public int WidthFirstPart { get; set; }

		public int? WidthSecondPart { get; set; }

		public int HeightFirstPart { get; set; }

		public int? HeightSecondPart { get; set; }

		public int Weight { get; set; }

		public MeasurementUnit MeasurementUnit { get; set; }
	}
}
