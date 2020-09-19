using DnDSolutions.Data.Models.Animals;
using DnDSolutions.Data.Models.Chat;
using DnDSolutions.Data.Models.Freights;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public TrailerType TrailerType { get; set; }
        
        [Required]
        public ComodityType ComodityType { get; set; }

        public List<ATV> ATVs { get; set; } = new List<ATV>();

        public List<Boat> Boats { get; set; } = new List<Boat>();

        public List<Car> Cars { get; set; } = new List<Car>();

        public List<HeavyVehicle> HeavyVehicles { get; set; } = new List<HeavyVehicle>();

        public List<HouseholdItem> HouseholdItems { get; set; } = new List<HouseholdItem>();

        public List<Piano> Pianos { get; set; } = new List<Piano>();

        public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

        public List<RecreationalVehicle> RecreationalVehicles { get; set; } = new List<RecreationalVehicle>();

        public List<Snowmobile> Snowmobiles { get; set; } = new List<Snowmobile>();

        public List<Art> Arts { get; set; } = new List<Art>();

        public List<Move> Moves { get; set; } = new List<Move>();

        public List<Office> Offices { get; set; } = new List<Office>();

        public List<Cat> Cats { get; set; } = new List<Cat>();

        public List<Dog> Dogs { get; set; } = new List<Dog>();

        public List<Horse> Horses { get; set; } = new List<Horse>();

        public List<Livestock> Livestock { get; set; } = new List<Livestock>();

        public List<LessThanContainerLoad> LessThanContainerLoads { get; set; } = new List<LessThanContainerLoad>();

        public string Role { get; set; }

        public bool IsApproved { get; set; }

        public List<Bid> Bids { get; set; } = new List<Bid>();

        public List<Message> Messages { get; set; } = new List<Message>();
	}
}
