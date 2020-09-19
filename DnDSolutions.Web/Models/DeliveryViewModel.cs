using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Web.Models.Bids;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models
{
	public class DeliveryViewModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public RouteSummaryViewModel RouteSummary { get; set; }

		public List<Photo> Photos { get; set; } = new List<Photo>();

		public List<BidViewModel> Bids { get; set; } = new List<BidViewModel>();

		public string UserId { get; set; }

		public string Username { get; set; }

		public string AdditionalDetails { get; set; }
	}
}
