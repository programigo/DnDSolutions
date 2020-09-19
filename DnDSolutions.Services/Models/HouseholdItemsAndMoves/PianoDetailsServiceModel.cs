using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

namespace DnDSolutions.Services.Models.HouseholdItemsAndMoves
{
	public class PianoDetailsServiceModel : DeliveryItem, IMapFrom<Piano>, IHaveCustomMapping
	{
		public PianoType Type { get; set; }

		public VerticalPianoType VerticalType { get; set; }

		public HorizontalPianoType HorizontalType { get; set; }

		public bool? IsOnCasters { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Piano, PianoListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(p => p.UserId));
	}
}
