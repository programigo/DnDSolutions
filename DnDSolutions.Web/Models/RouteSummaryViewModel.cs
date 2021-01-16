using System;

namespace DnDSolutions.Web.Models
{
	public class RouteSummaryViewModel
	{
		public string PickupLocation { get; set; }

		public string DeliveryLocation { get; set; }

		public DateTime CollectionDate { get; set; }

		public DateTime DeliveryDate { get; set; }
	}
}
