using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Animals;

namespace DnDSolutions.Services.Models.Animals
{
	public class LivestockListingServiceModel : DeliveryItem, IMapFrom<Livestock>, IHaveCustomMapping
	{
        public string Breed { get; set; }

        public int TotalWeight { get; set; }

        public int Count { get; set; }

        public bool HasAllVaccinations { get; set; }

        public bool HasAllTags { get; set; }

        public bool HasSpecificNeeds { get; set; }

        public bool IsInCorral { get; set; }

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Livestock, LivestockListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(ls => ls.UserId));
	}
}
