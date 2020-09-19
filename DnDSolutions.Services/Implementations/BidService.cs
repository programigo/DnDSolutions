using DnDSolutions.Data;

namespace DnDSolutions.Services.Implementations
{
	public class BidService : IBidService
	{
		private readonly DnDSolutionsDbContext db;

		public BidService(DnDSolutionsDbContext db)
		{
			this.db = db;
		}

		public void CreateBid(int amount, BidCurrency currency, int deliveryItemId, string userId)
		{
			Bid bid = new Bid
			{
				Amount = amount,
				Currency = currency,
				DeliveryItemId = deliveryItemId,
				UserId = userId,
			};

			this.db.Add(bid);

			this.db.SaveChanges();
		}
	}
}
