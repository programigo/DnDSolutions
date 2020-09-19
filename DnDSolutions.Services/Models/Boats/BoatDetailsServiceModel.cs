using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models.Boats
{
	public class BoatDetailsServiceModel : DeliveryItem, IMapFrom<Boat>, IHaveCustomMapping
	{
		public BoatType Type { get; set; }

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

		public bool IsOnTrailer { get; set; }

		public BoatServiceType ServiceType { get; set; }

		public string Description { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Boat, BoatListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(b => b.UserId));
	}
}
