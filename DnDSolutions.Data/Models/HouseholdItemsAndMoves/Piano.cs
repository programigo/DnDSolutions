namespace DnDSolutions.Data.Models.HouseholdItemsAndMoves
{
    public class Piano : DeliveryItem
    {
        public PianoType Type { get; set; }

        public VerticalPianoType VerticalType { get; set; }

        public HorizontalPianoType HorizontalType { get; set; }

        public bool? IsOnCasters { get; set; }
    }
}
