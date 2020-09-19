using System;

namespace DnDSolutions.Web.Models
{
	public class RouteSummaryViewModel
	{
		public string PickupLocation { get; set; }

		public string DeliveryLocation { get; set; }

		public DateTime CollectionDateEarliest { get; set; }

		public DateTime CollectionDateLatest { get; set; }

		public DateTime DeliveryDateEarliest { get; set; }

		public DateTime DeliveryDateLatest { get; set; }
	}
}
