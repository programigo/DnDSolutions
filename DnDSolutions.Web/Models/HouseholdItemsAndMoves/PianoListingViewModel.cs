using DnDSolutions.Services.Models.HouseholdItemsAndMoves;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
	public class PianoListingViewModel
	{
		public IEnumerable<PianoListingServiceModel> Pianos { get; set; }

		public int TotalPianos { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalPianos / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
