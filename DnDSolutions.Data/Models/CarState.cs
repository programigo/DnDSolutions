using System;

namespace DnDSolutions.Data.Models
{
    [Flags]
    public enum CarState
    {
        Operable = 1,
        Convertible = 2,
        Modified = 4,
    }
}
