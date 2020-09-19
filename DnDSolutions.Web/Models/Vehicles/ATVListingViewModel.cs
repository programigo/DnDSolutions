using DnDSolutions.Services.Models.Vehicles;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Vehicles
{
	public class ATVListingViewModel
	{
		public IEnumerable<ATVListingServiceModel> ATVs { get; set; }

		public int TotalATVs { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalATVs / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
