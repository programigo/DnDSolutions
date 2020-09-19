using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Freights;

namespace DnDSolutions.Services.Models.Freights
{
	public class LessThanContainerLoadDetailsServiceModel : DeliveryItem, IMapFrom<LessThanContainerLoad>, IHaveCustomMapping
	{
        public LessThanContainerLoadType Type { get; set; }

        public HandlingUnitType HandlingUnit { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }

        public int LengthFirstPart { get; set; }

        public int? LengthSecondPart { get; set; }

        public int WidthFirstPart { get; set; }

        public int? WidthSecondPart { get; set; }

        public int HeightFirstPart { get; set; }

        public int? HeightSecondPart { get; set; }

        public int Weight { get; set; }

        public int Quantity { get; set; }

        public bool IsStackable { get; set; }

        public bool IsHazardous { get; set; }

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<LessThanContainerLoad, LessThanContainerLoadListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(lcl => lcl.UserId));
	}
}
