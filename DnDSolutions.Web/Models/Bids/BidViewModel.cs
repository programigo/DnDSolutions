using DnDSolutions.Data;

namespace DnDSolutions.Web.Models.Bids
{
	public class BidViewModel
	{
		public int Id { get; set; }

		public int Amount { get; set; }

		public BidCurrency Currency { get; set; }

		public int DeliveryItemId { get; set; }

		public string UserId { get; set; }
	}
}
