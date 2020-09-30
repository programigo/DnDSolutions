using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public enum MoveType
    {
        [Display(Name = "Small Studio")]
        SmallStudio,
        [Display(Name = "One Bedroom Apartment")]
        OneBedroomApartment,
        [Display(Name = "Two Bedroom Apartment")]
        TwoBedroomApartment,
        [Display(Name = "Three Bedroom Apartment")]
        ThreeBedroomApartment,
        [Display(Name = "Two Bedroom House")]
        TwoBedroomHouse,
        [Display(Name = "Three Bedroom House")]
        ThreeBedroomHouse,
        [Display(Name = "Four Bedroom House")]
        FourBedroomHouse,
    }
}
