using DnDSolutions.Services.Models.Vehicles;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Vehicles
{
	public class RecreationalVehicleListingViewModel
	{
		public IEnumerable<RecreationalVehicleListingServiceModel> RecreationalVehicles { get; set; }

		public int TotalRecreationalVehicles { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalRecreationalVehicles / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
