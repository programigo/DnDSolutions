using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public enum CarBodyType
    {
        [Display(Name = "Coupe")]
        Coupe,
        [Display(Name = "Estate")]
        Estate,
        [Display(Name = "Hatchback")]
        Hatchback,
        [Display(Name = "Mini Van")]
        MiniVan,
        [Display(Name = "People Mover")]
        PeopleMover,
        [Display(Name = "Pickup Full Size")]
        PickupFullSize,
        [Display(Name = "Pickup Heavy Duty")]
        PickupHeavyDuty,
        [Display(Name = "Pickup Mid Size")]
        PickupMidSize,
        [Display(Name = "Saloon")]
        Saloon,
        [Display(Name = "SUV Compact")]
        SUVCompact,
        [Display(Name = "SUV Full Size")]
        SUVFullSize,
        [Display(Name = "SUV Mid Size")]
        SUVMidSize,
    }
}
