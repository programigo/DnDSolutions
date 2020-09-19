using DnDSolutions.Data.Models;

namespace DnDSolutions.Data
{
	public class Bid
	{
		public int Id { get; set; }

		public int Amount { get; set; }

		public BidCurrency Currency { get; set; }

		public int DeliveryItemId { get; set; }

		public DeliveryItem DeliveryItem { get; set; }

		public string UserId { get; set; }

		public User User { get; set; }
	}
}
