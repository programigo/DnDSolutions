namespace DnDSolutions.Data.Models.Photos
{
    public class Photo
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public int DeliveryItemId { get; set; }

        public DeliveryItem DeliveryItem { get; set; }
    }
}
