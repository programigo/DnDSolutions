using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.HouseholdItemsAndMoves
{
    public class OfficeFormModel : DeliveryFormModel
	{
        [Required]
        [Display(Name = "Collection Floor")]
        public int CollectionFloor { get; set; }

        [Required]
        [Display(Name = "Has the collection floor elevator?")]
        public bool HasCollectionFloorElevator { get; set; }

        [Required]
        [Display(Name = "Delivery Floor")]
        public int DeliveryFloor { get; set; }

        [Required]
        [Display(Name = "Has the delivery floor elevator?")]
        public bool HasDeliveryFloorElevator { get; set; }

        [Required]
        [Display(Name = "Is there any items that need to be disassembled?")]
        public bool HasDisassemblyItems { get; set; }

        [Required]
        [Display(Name = "Is there any items that need to be reassembled?")]
        public bool HasReassemblyItems { get; set; }
    }
}
