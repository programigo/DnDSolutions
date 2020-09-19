using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
	public class MoveFormModel : DeliveryFormModel
	{
		[Required]
		public MoveType Type { get; set; }
	}
}
