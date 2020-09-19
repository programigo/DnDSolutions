using DnDSolutions.Services.Models.Animals;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Animals
{
	public class AnimalListingViewModel
	{
		public IEnumerable<CatListingServiceModel> Cats { get; set; }

		public IEnumerable<DogListingServiceModel> Dogs { get; set; }

		public IEnumerable<HorseListingServiceModel> Horses { get; set; }

		public IEnumerable<LivestockListingServiceModel> Livestock { get; set; }

		public int TotalAnimals { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalAnimals / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
