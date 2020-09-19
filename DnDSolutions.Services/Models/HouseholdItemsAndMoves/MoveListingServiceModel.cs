using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

namespace DnDSolutions.Services.Models.HouseholdItemsAndMoves
{
	public class MoveListingServiceModel : DeliveryItem, IMapFrom<Move>, IHaveCustomMapping
	{
		public MoveType Type { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Move, MoveListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(m => m.UserId));
	}
}
