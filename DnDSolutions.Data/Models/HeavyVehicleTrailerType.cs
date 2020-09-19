using System;

namespace DnDSolutions.Data.Models
{
    [Flags]
    public enum HeavyVehicleTrailerType
    {
        DryVan = 1,
        Flatbed = 2,
        LowLoader = 4,
        StepDeck = 8,
        RefrigeratedVehicle = 16,
        AirSuspensionVehicle = 32,
        FlatbedDouble = 64,
        StretchedFlatbed = 128,
        Tanker = 256,
        SemiLowloader = 512,
        CarTransporter = 1024,
        DoubleCabVan = 2048,
        TippingTrailer = 4096,
    }
}
