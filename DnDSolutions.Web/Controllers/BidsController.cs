using DnDSolutions.Data.Models;
using DnDSolutions.Services;
using DnDSolutions.Web.Models.Bids;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DnDSolutions.Web.Controllers
{
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.TransporterRole)]
	public class BidsController : Controller
	{
		private UserManager<User> userManager;
		private readonly IBidService bidService;

		public BidsController(UserManager<User> userManager, IBidService bidService)
		{
			this.userManager = userManager;
			this.bidService = bidService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(BidFormModel bidFormModel)
		{
			if (ModelState.IsValid)
			{
				this.bidService.CreateBid(
					bidFormModel.Amount,
					bidFormModel.Currency,
					bidFormModel.DeliveryId,
					this.userManager.GetUserId(User));

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}
	}
}