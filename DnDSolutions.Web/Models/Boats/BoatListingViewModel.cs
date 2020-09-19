using DnDSolutions.Services.Models.Boats;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Boats
{
	public class BoatListingViewModel
	{
		public IEnumerable<BoatListingServiceModel> Boats { get; set; }

		public int TotalBoats { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalBoats / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
