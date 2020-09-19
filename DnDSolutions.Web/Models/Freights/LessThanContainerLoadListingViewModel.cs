using DnDSolutions.Services.Models.Freights;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Freights
{
	public class LessThanContainerLoadListingViewModel
	{
		public IEnumerable<LessThanContainerLoadListingServiceModel> LCLs { get; set; }

		public int TotalLCLs { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalLCLs / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
