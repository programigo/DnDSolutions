using DnDSolutions.Data.Models;

namespace DnDSolutions.Web.Areas.Admin.Models
{
	public class AdminUserDetailsViewModel
	{
		public string Username { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Role { get; set; }

		public TrailerType TrailerType { get; set; }

		public ComodityType ComodityType { get; set; }
	}
}
