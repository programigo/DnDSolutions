using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Animals;

namespace DnDSolutions.Services.Models.Animals
{
	public class HorseDetailsServiceModel : DeliveryItem, IMapFrom<Horse>, IHaveCustomMapping
	{
        public int Count { get; set; }
        
        public HorseBreed Breed { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public string Name { get; set; }

        public void ConfigureMapping(Profile mapper)
			=> mapper
				.CreateMap<Horse, HorseListingServiceModel>()
				.ForMember(u => u.UserId, cfg => cfg.MapFrom(h => h.UserId));
	}
}
