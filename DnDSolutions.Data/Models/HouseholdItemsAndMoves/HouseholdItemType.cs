using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public enum HouseholdItemType
    {
        [Display(Name = "Furniture")]
        Furniture,
        [Display(Name = "Appliances")]
        Appliances,
        [Display(Name = "Home Electronics")]
        HomeElectronics,
        [Display(Name = "Outdoor Equipment")]
        OutdoorEquipment,
        [Display(Name = "Sporting Equipment")]
        SportingEquipment,
        [Display(Name = "Pool Tables")]
        PoolTables,
    }
}
