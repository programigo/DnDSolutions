using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Freights;
using DnDSolutions.Services;
using DnDSolutions.Services.Models.Freights;
using DnDSolutions.Web.Models;
using DnDSolutions.Web.Models.Bids;
using DnDSolutions.Web.Models.Freights;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DnDSolutions.Web.Controllers
{
	[Route("Freights")]
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.CustomerRole + ", " + GlobalConstants.TransporterRole)]
	public class FreightsController : Controller
	{
		private UserManager<User> userManager;
		private readonly IFreightService freightService;
		private readonly IWebHostEnvironment hostingEnvironment;
		private readonly IEmailSender emailSender;

		public FreightsController(UserManager<User> userManager, IFreightService freightService, IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
		{
			this.userManager = userManager;
			this.freightService = freightService;
			this.hostingEnvironment = hostingEnvironment;
			this.emailSender = emailSender;
		}

		public IActionResult Index() => View();

		[Route("LessThanContainerLoads/Create")]
		public IActionResult CreateLessThanContainerLoad() => View();

		[HttpPost]
		[Route("LessThanContainerLoads/Create")]
		public async Task<IActionResult> CreateLessThanContainerLoad(LessThanContainerLoadFormModel lessThanContainerLoadModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (lessThanContainerLoadModel.Photos != null && lessThanContainerLoadModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in lessThanContainerLoadModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				LessThanContainerLoad lessThanContainerLoad = this.freightService.CreateLessThanLoad(
					lessThanContainerLoadModel.Title,
					lessThanContainerLoadModel.Type,
					lessThanContainerLoadModel.HandlingUnit,
					lessThanContainerLoadModel.MeasurementUnit,
					lessThanContainerLoadModel.LengthFirstPart,
					lessThanContainerLoadModel.LengthSecondPart,
					lessThanContainerLoadModel.WidthFirstPart,
					lessThanContainerLoadModel.WidthSecondPart,
					lessThanContainerLoadModel.HeightFirstPart,
					lessThanContainerLoadModel.HeightSecondPart,
					lessThanContainerLoadModel.Weight,
					lessThanContainerLoadModel.Quantity,
					lessThanContainerLoadModel.IsStackable,
					lessThanContainerLoadModel.IsHazardous,
					lessThanContainerLoadModel.PickupLocation,
					lessThanContainerLoadModel.DeliveryLocation,
					lessThanContainerLoadModel.CollectionDateEarliest,
					lessThanContainerLoadModel.CollectionDateLatest,
					lessThanContainerLoadModel.DeliveryDateEarliest,
					lessThanContainerLoadModel.DeliveryDateLatest,
					photoPaths,
					lessThanContainerLoadModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{lessThanContainerLoad.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("LessThanContainerLoads/{id}")]
		public IActionResult LessThanContainerLoadDetails(int id)
		{
			LessThanContainerLoadDetailsServiceModel lclServiceModel = this.freightService.LessThanContainerLoadDetails(id);

			LessThanContainerLoadDetailsViewModel lclViewModel = new LessThanContainerLoadDetailsViewModel
			{
				Id = lclServiceModel.Id,
				Title = lclServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = lclServiceModel.PickupLocation,
					DeliveryLocation = lclServiceModel.DeliveryLocation,
					CollectionDateEarliest = lclServiceModel.CollectionDateEarliest,
					CollectionDateLatest = lclServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = lclServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = lclServiceModel.DeliveryDateLatest,
				},
				Type = lclServiceModel.Type,
				HandlingUnit = lclServiceModel.HandlingUnit,
				MeasurementUnit = lclServiceModel.MeasurementUnit,
				LengthFirstPart = lclServiceModel.LengthFirstPart,
				LengthSecondPart = lclServiceModel.LengthSecondPart,
				WidthFirstPart = lclServiceModel.WidthFirstPart,
				WidthSecondPart = lclServiceModel.WidthSecondPart,
				HeightFirstPart = lclServiceModel.HeightFirstPart,
				HeightSecondPart = lclServiceModel.HeightSecondPart,
				Weight = lclServiceModel.Weight,
				Quantity = lclServiceModel.Quantity,
				IsStackable = lclServiceModel.IsStackable,
				AdditionalDetails = lclServiceModel.AdditionalDetails,
				Photos = lclServiceModel.Photos,
				Bids = lclServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
			};

			return View(lclViewModel);
		}

		private static BidViewModel ConvertBidToViewModel(Bid bid)
		{
			return new BidViewModel
			{
				Id = bid.Id,
				Amount = bid.Amount,
				Currency = bid.Currency,
				DeliveryItemId = bid.DeliveryItemId,
				UserId = bid.UserId,
			};
		}
	}
}
