using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Animals;

namespace DnDSolutions.Services.Models.Animals
{
	public class CatListingServiceModel : DeliveryItem, IMapFrom<Cat>, IHaveCustomMapping
	{
		public int Count { get; set; }

		public string Name { get; set; }

		public string Breed { get; set; }

		public int Weight { get; set; }

		public bool HasAllVaccinations { get; set; }

		public bool HasCarrier { get; set; }

		public bool HasSpecificNeeds { get; set; }

		public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Cat, CatListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(c => c.UserId));
	}
}
