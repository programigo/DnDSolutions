using DnDSolutions.Data.Models.Photos;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Deliveries
{
	public class DeliveryListItemModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string PickupLocation { get; set; }

		public string DeliveryLocation { get; set; }

		public DateTime CollectionDate { get; set; }

		public List<Photo> Photos { get; set; } = new List<Photo>();

		public string Controller { get; set; }

		public string Action { get; set; }

		public string RemovingAction { get; set; }
	}
}
