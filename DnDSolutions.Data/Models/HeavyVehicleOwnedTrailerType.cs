using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public enum HeavyVehicleOwnedTrailerType
    {
        [Display(Name = "Dry Van")]
        DryVan = 1,
        [Display(Name = "Flatbed")]
        Flatbed = 2,
        [Display(Name = "Low Loader")]
        LowLoader = 3,
        [Display(Name = "Step Deck")]
        StepDeck = 4,
        [Display(Name = "Refrigerated Vehicle")]
        RefrigeratedVehicle = 5,
        [Display(Name = "Air Suspension Vehicle")]
        AirSuspensionVehicle = 6,
        [Display(Name = "Flatbed Double")]
        FlatbedDouble = 7,
        [Display(Name = "Stretched Flatbed")]
        StretchedFlatbed = 8,
        [Display(Name = "Tanker")]
        Tanker = 9,
        [Display(Name = "Semi Lowloader")]
        SemiLowloader = 10,
        [Display(Name = "Car Transporter")]
        CarTransporter = 11,
        [Display(Name = "Double Cab Van")]
        DoubleCabVan = 12,
        [Display(Name = "Tipping Trailer")]
        TippingTrailer = 13,
    }
}
