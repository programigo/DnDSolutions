namespace DnDSolutions.Data.Models.Animals
{
    public interface ISmallMammal
    {
        int Count { get; set; }

        string Name { get; set; }

        string Breed { get; set; }

        int Weight { get; set; }

        bool HasAllVaccinations { get; set; }

        bool HasCarrier { get; set; }

        bool HasSpecificNeeds { get; set; }
    }
}
