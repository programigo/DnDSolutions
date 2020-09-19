using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

namespace DnDSolutions.Services.Models.HouseholdItemsAndMoves
{
	public class OfficeListingServiceModel : DeliveryItem, IMapFrom<Office>, IHaveCustomMapping
	{
        public int CollectionFloor { get; set; }

        public bool HasCollectionFloorElevator { get; set; }

        public int DeliveryFloor { get; set; }

        public bool HasDeliveryFloorElevator { get; set; }

        public bool HasDisassemblyItems { get; set; }

        public bool HasReassemblyItems { get; set; }

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Office, OfficeListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(o => o.UserId));
	}
}
