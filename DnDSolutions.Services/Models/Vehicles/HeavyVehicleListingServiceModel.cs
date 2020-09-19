using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models.Vehicles
{
	public class HeavyVehicleListingServiceModel : DeliveryItem, IMapFrom<HeavyVehicle>, IHaveCustomMapping
	{
        public HeavyVehicleType Type { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public bool IsOnTrailer { get; set; }

        public HeavyVehicleOwnedTrailerType OwnedTrailerType { get; set; }

        public HeavyVehicleTrailerType TrailerType { get; set; }

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<HeavyVehicle, HeavyVehicleListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(hv => hv.UserId));
	}
}
