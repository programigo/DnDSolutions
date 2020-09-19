using DnDSolutions.Data.Models;

namespace DnDSolutions.Web.Models.Vehicles
{
    public class HeavyVehicleDetailsViewModel : DeliveryViewModel
	{
        public HeavyVehicleType Type { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public bool IsOnTrailer { get; set; }

        public HeavyVehicleOwnedTrailerType OwnedTrailerType { get; set; }

        public HeavyVehicleTrailerType TrailerType { get; set; }
    }
}
