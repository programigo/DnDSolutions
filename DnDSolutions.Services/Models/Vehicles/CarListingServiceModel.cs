using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models.Vehicles
{
	public class CarListingServiceModel : DeliveryItem, IMapFrom<Car>, IHaveCustomMapping
	{
		public CarBodyType BodyType { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public CarState State { get; set; }

		public ServiceType ServiceType { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Car, CarListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(c => c.UserId));
	}
}
