using DnDSolutions.Data;

namespace DnDSolutions.Services
{
	public interface IBidService
	{
		void CreateBid(int amount, BidCurrency currency, int deliveryItemId, string userId);
	}
}
