using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public class Move : DeliveryItem
    {
        [Required]
        public MoveType Type { get; set; }
    }
}
