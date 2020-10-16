using DnDSolutions.Services.Admin;
using DnDSolutions.Web.Controllers;
using DnDSolutions.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DnDSolutions.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.ModeratorRole)]
	public class DeliveriesController : Controller
	{
		private readonly IAdminDeliveryService deliveryService;

		public DeliveriesController(IAdminDeliveryService deliveryService)
		{
			this.deliveryService = deliveryService;
		}

		public IActionResult RemoveArt(int id)
		{
			this.deliveryService.RemoveArt(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveATV(int id)
		{
			this.deliveryService.RemoveATV(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveBoat(int id)
		{
			this.deliveryService.RemoveBoat(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveCar(int id)
		{
			this.deliveryService.RemoveCar(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveCat(int id)
		{
			this.deliveryService.RemoveCat(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveDog(int id)
		{
			this.deliveryService.RemoveDog(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveHeavyVehicle(int id)
		{
			this.deliveryService.RemoveHeavyVehicle(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveHorse(int id)
		{
			this.deliveryService.RemoveHorse(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveHouseholdItem(int id)
		{
			this.deliveryService.RemoveHouseholdItem(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveLessThanContainerLoad(int id)
		{
			this.deliveryService.RemoveLessThanContainerLoad(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveLivestock(int id)
		{
			this.deliveryService.RemoveLivestock(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveMotorcycle(int id)
		{
			this.deliveryService.RemoveMotorcycle(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveMoveItem(int id)
		{
			this.deliveryService.RemoveMoveItem(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveOffice(int id)
		{
			this.deliveryService.RemoveOffice(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemovePiano(int id)
		{
			this.deliveryService.RemovePiano(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}

		public IActionResult RemoveRecreationalVehicle(int id)
		{
			this.deliveryService.RemoveRecreationalVehicle(id);

			TempData.AddSuccessMessage($"Delivery successfully removed");

			return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
		}
	}
}
