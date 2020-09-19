using DnDSolutions.Common.Mapping;
using DnDSolutions.Data.Models;

namespace DnDSolutions.Services.Admin.Models
{
    public class AdminUserListingServiceModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
    }
}
