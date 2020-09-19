using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models.Vehicles
{
	public class ATVDetailsServiceModel : DeliveryItem, IMapFrom<ATV>, IHaveCustomMapping
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

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<ATV, ATVListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(atv => atv.UserId));
	}
}
