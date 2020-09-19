using System.Security.Claims;

namespace DnDSolutions.Services
{
	public static class UserIdentityExtensions
	{
		public static string GetUserId(this ClaimsPrincipal user)
		{
			if (!user.Identity.IsAuthenticated)
				return null;

			ClaimsPrincipal currentUser = user;
			return currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
		}
	}
}
