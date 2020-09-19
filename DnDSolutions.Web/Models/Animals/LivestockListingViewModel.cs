using DnDSolutions.Services.Models.Animals;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Animals
{
	public class LivestockListingViewModel
	{
		public IEnumerable<LivestockListingServiceModel> Livestock { get; set; }

		public int TotalLivestock { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalLivestock / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
