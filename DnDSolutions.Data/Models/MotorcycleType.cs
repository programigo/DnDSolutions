using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public enum MotorcycleType
    {
        [Display(Name = "Cabin")]
        Cabin,
        [Display(Name = "Cruiser")]
        Cruiser,
        [Display(Name = "Dual Sport")]
        DualSport,
        [Display(Name = "Moped")]
        Moped,
        [Display(Name = "Motocross")]
        Motocross,
        [Display(Name = "Scooter")]
        Scooter,
        [Display(Name = "Sport Bike")]
        SportBike,
        [Display(Name = "Standard")]
        Standard,
        [Display(Name = "Tourer")]
        Tourer,
    }
}
