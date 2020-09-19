using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public class Office : DeliveryItem
    {
        [Required]
        public int CollectionFloor { get; set; }

        [Required]
        public bool HasCollectionFloorElevator { get; set; }

        [Required]
        public int DeliveryFloor { get; set; }

        [Required]
        public bool HasDeliveryFloorElevator { get; set; }

        [Required]
        public bool HasDisassemblyItems { get; set; }

        [Required]
        public bool HasReassemblyItems { get; set; }
    }
}
