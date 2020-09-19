using System;

namespace DnDSolutions.Data.Models
{
    [Flags]
    public enum ComodityType
    {
        HouseholdGoods = 1,
        HouseholdAndOfficeMoves = 2,
        Vehicles = 4,
        MotorcyclesAndPowerSports = 8,
        Boats = 16,
        PlantAndHeavyEquipment = 32,
        LessThanContainerLoad = 64,
        FullLoad = 128,
        Pets = 256,
        HorsesLivestock = 512,
        AntiquesAndSpecialCareItems = 1024,
        BusinessIndustrialGoods = 2048,
        FoodAgriculturalGoods = 4096,
    }
}
