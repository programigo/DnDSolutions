using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Services;
using DnDSolutions.Services.Models.Boats;
using DnDSolutions.Web.Models;
using DnDSolutions.Web.Models.Bids;
using DnDSolutions.Web.Models.Boats;
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
	[Route("boats")]
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.CustomerRole + ", " + GlobalConstants.TransporterRole)]
	public class BoatsController : Controller
	{
		private UserManager<User> userManager;
		private readonly IBoatService boatService;
		private readonly IWebHostEnvironment hostingEnvironment;
		private readonly IEmailSender emailSender;

		public BoatsController(UserManager<User> userManager, IBoatService boatService, IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
		{
			this.userManager = userManager;
			this.boatService = boatService;
			this.hostingEnvironment = hostingEnvironment;
			this.emailSender = emailSender;
		}

		public IActionResult Create() => View();

		[HttpPost]
		public async Task<IActionResult> Create(BoatFormModel boatModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (boatModel.Photos != null && boatModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in boatModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Boat boat = this.boatService.CreateBoat(
					boatModel.Title,
					boatModel.Type,
					boatModel.Make,
					boatModel.Model,
					boatModel.MeasurementUnit,
					boatModel.LengthFirstPart,
					boatModel.LengthSecondPart,
					boatModel.WidthFirstPart,
					boatModel.WidthSecondPart,
					boatModel.HeightFirstPart,
					boatModel.HeightSecondPart,
					boatModel.Weight,
					boatModel.IsOnTrailer,
					boatModel.PickupLocation,
					boatModel.DeliveryLocation,
					boatModel.Description,
					boatModel.DeliveryDateEarliest,
					boatModel.CollectionDateLatest,
					boatModel.DeliveryDateEarliest,
					boatModel.DeliveryDateLatest,
					boatModel.ServiceType,
					photoPaths,
					boatModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{boat.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("details/{id}")]
		public IActionResult Details(int id)
		{
			BoatDetailsServiceModel boatServiceModel = this.boatService.BoatDetails(id);

			BoatDetailsViewModel boatViewModel = new BoatDetailsViewModel
			{
				Id = boatServiceModel.Id,
				Title = boatServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = boatServiceModel.PickupLocation,
					DeliveryLocation = boatServiceModel.DeliveryLocation,
					CollectionDateEarliest = boatServiceModel.CollectionDateEarliest,
					CollectionDateLatest = boatServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = boatServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = boatServiceModel.DeliveryDateLatest,
				},
				Type = boatServiceModel.Type,
				Make = boatServiceModel.Make,
				Model = boatServiceModel.Model,
				MeasurementUnit = boatServiceModel.MeasurementUnit,
				LengthFirstPart = boatServiceModel.LengthFirstPart,
				LengthSecondPart = boatServiceModel.LengthSecondPart,
				WidthFirstPart = boatServiceModel.WidthFirstPart,
				WidthSecondPart = boatServiceModel.WidthSecondPart,
				HeightFirstPart = boatServiceModel.HeightFirstPart,
				HeightSecondPart = boatServiceModel.HeightSecondPart,
				Weight = boatServiceModel.Weight,
				IsOnTrailer = boatServiceModel.IsOnTrailer,
				ServiceType = boatServiceModel.ServiceType,
				Description = boatServiceModel.Description,
				Photos = boatServiceModel.Photos,
				Bids = boatServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = boatServiceModel.AdditionalDetails,
			};

			return View(boatViewModel);
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
