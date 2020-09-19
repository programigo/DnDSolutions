using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models.Vehicles
{
	public class MotorcycleListingServiceModel : DeliveryItem, IMapFrom<Motorcycle>, IHaveCustomMapping
	{
		public MotorcycleType Type { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public MotorcycleState State { get; set; }

		public ServiceType ServiceType { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Motorcycle, MotorcycleListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(m => m.UserId));
	}
}
