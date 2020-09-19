using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

namespace DnDSolutions.Services.Models.HouseholdItemsAndMoves
{
	public class HouseholdItemDetailsServiceModel : DeliveryItem, IMapFrom<HouseholdItem>, IHaveCustomMapping
	{
        public int NumberOfItems { get; set; }

        public HouseholdItemType Type { get; set; }

        public bool IsPalletised { get; set; }

        public bool IsCrated { get; set; }

        public bool IsStickable { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }

        public int LengthFirstPart { get; set; }

        public int? LengthSecondPart { get; set; }

        public int WidthFirstPart { get; set; }

        public int? WidthSecondPart { get; set; }

        public int HeightFirstPart { get; set; }

        public int? HeightSecondPart { get; set; }

        public int Weight { get; set; }

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<HouseholdItem, HouseholdItemListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(h => h.UserId));
	}
}
