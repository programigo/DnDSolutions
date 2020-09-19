using DnDSolutions.Common.Mapping;
using DnDSolutions.Services.Admin.Models;

namespace DnDSolutions.Web.Areas.Admin.Models
{
    public class AdminUserListingViewModel : IMapFrom<AdminUserListingServiceModel>
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
    }
}
