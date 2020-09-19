using System;

namespace DnDSolutions.Data.Models
{
    [Flags]
    public enum BoatServiceType
    {
        OpenTransport = 1,
        TowedService = 2,
        FlatbedTransportService = 4,
        EnclosedTransport = 8,
        SkipperDeliveryService = 16,
        OceanFreightContainerService = 32,
    }
}
