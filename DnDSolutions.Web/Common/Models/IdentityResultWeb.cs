using Microsoft.AspNetCore.Identity;

namespace DnDSolutions.Web.Common.Models
{
	public class IdentityResultWeb : IdentityResult
	{
		private readonly IdentityResult result;

		public IdentityResultWeb(IdentityResult result)
		{
			this.result = result;
		}
	}
}
