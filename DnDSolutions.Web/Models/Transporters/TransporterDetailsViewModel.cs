using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Transporters
{
    public class TransporterDetailsViewModel
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public IEnumerable<string> TrailerTypes { get; set; }

        public IEnumerable<string> ComodityTypes { get; set; }
    }
}
