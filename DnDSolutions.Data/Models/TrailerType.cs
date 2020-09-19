using System;

namespace DnDSolutions.Data.Models
{
    [Flags]
    public enum TrailerType
    {
        DryVan = 1,
        Flatbed = 2,
        LowLoader = 4,
        StepDeck = 8,
        PowerOnly = 16,
        RefrigeratedVehicle = 32,
        AirRideVan = 64,
        AutoCarrier = 128,
        Dump = 256,
        FlatbedDouble = 512,
        RemovableGooseneck = 1024,
        StretchFlatbed = 2048,
        Tanker = 4096,
        VanDouble = 8192,
    }
}
