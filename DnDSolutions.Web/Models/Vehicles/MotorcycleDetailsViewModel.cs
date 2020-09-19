using DnDSolutions.Data.Models;

namespace DnDSolutions.Web.Models.Vehicles
{
	public class MotorcycleDetailsViewModel : DeliveryViewModel
	{
		public MotorcycleType Type { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public MotorcycleState State { get; set; }

		public ServiceType ServiceType { get; set; }
	}
}
