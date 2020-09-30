using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public enum HeavyVehicleType
    {
        [Display(Name = "Commercial Truck")]
        CommercialTruck,
        [Display(Name = "Farm Equipment")]
        FarmEquipment,
        [Display(Name = "Construction Equipment")]
        ConstructionEquipment,
    }
}
