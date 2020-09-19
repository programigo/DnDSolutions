using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
	public class PianoFormModel : DeliveryFormModel
	{
		[Display(Name = "Piano Type")]
		public PianoType Type { get; set; }

		[Display(Name = "Vertical Type")]
		public VerticalPianoType VerticalType { get; set; }

		[Display(Name = "Horizontal Type")]
		public HorizontalPianoType HorizontalType { get; set; }

		[Display(Name = "Is your piano on casters?")]
		public bool? IsOnCasters { get; set; }
	}
}
