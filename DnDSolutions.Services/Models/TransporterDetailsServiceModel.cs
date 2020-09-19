using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Models
{
    public class TransporterDetailsServiceModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public TrailerType TrailerType { get; set; }

        public ComodityType ComodityType { get; set; }
    }
}
