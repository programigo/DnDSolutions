using System;

namespace DnDSolutions.Data.Models
{
    [Flags]
    public enum MotorcycleState
    {
        Operable = 1,
        Sidecar = 2,
        Trike = 4,
        Modified = 8,
    }
}
