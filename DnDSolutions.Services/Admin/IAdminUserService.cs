using DnDSolutions.Data.Models;
using DnDSolutions.Services.Admin.Models;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Admin
{
    public interface IAdminUserService
    {
        IQueryable<AdminUserListingServiceModel> All();

        IQueryable<AdminUserListingServiceModel> GetPendingUsers();

        IQueryable<User> GetUserByName(string username);

        void Approve(string id);

        void Remove(string id);

        bool IsApprovedUser(string username);
    }
}
