using DnDSolutions.Data.Models;

namespace DnDSolutions.Web.Models.Vehicles
{
	public class CarDetailsViewModel : DeliveryViewModel
	{
		public CarBodyType BodyType { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public CarState State { get; set; }

		public ServiceType ServiceType { get; set; }
	}
}
