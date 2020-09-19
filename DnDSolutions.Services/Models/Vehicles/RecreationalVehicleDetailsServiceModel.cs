using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models.Vehicles
{
	public class RecreationalVehicleDetailsServiceModel : DeliveryItem, IMapFrom<RecreationalVehicle>, IHaveCustomMapping
	{
		public CamperType Type { get; set; }

		public int Year { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public MeasurementUnit MeasurementUnit { get; set; }

		public int LengthFirstPart { get; set; }

		public int? LengthSecondPart { get; set; }

		public int WidthFirstPart { get; set; }

		public int? WidthSecondPart { get; set; }

		public int HeightFirstPart { get; set; }

		public int? HeightSecondPart { get; set; }

		public int Weight { get; set; }

		public bool? CanBeDriven { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<RecreationalVehicle, RecreationalVehicleListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(rv => rv.UserId));
	}
}
