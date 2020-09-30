using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
	public enum HorizontalPianoType
	{
		[Display(Name = "Petite Grand")]
		PetiteGrand = 1,
		[Display(Name = "Baby Grand")]
		BabyGrand = 2,
		[Display(Name = "Medium Grand")]
		MediumGrand = 3,
		[Display(Name = "Parlor Grand")]
		ParlorGrand = 4,
		[Display(Name = "Semiconcert And Ballroom")]
		SemiconcertAndBallroom = 5,
		[Display(Name = "Concert Grand")]
		ConcertGrand = 6,
		[Display(Name = "Other")]
		Other = 7,
	}
}
