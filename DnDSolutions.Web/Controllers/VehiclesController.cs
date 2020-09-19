using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Services;
using DnDSolutions.Services.Models.Vehicles;
using DnDSolutions.Web.Models;
using DnDSolutions.Web.Models.Bids;
using DnDSolutions.Web.Models.Vehicles;
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
	[Route("Vehicles")]
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.CustomerRole + ", " + GlobalConstants.TransporterRole)]
	public class VehiclesController : Controller
	{
		private UserManager<User> userManager;
		private readonly IVehicleService vehicleService;
		private readonly IWebHostEnvironment hostingEnvironment;
		private readonly IEmailSender emailSender;

		public VehiclesController(UserManager<User> userManager, IVehicleService vehicleService, IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
		{
			this.userManager = userManager;
			this.vehicleService = vehicleService;
			this.hostingEnvironment = hostingEnvironment;
			this.emailSender = emailSender;
		}

		public IActionResult Index() => View();

		[Route("ATVS/Create")]
		public IActionResult CreateATV() => View();

		[HttpPost]
		[Route("ATVS/Create")]
		public async Task<IActionResult> CreateATV(ATVFormModel atvModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (atvModel.Photos != null && atvModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in atvModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				ATV atv = this.vehicleService.CreateATV(
					atvModel.Title,
					atvModel.ItemDescription,
					atvModel.MeasurementUnit,
					atvModel.LengthFirstPart,
					atvModel.LengthSecondPart,
					atvModel.WidthFirstPart,
					atvModel.WidthSecondPart,
					atvModel.HeightFirstPart,
					atvModel.HeightSecondPart,
					atvModel.Weight,
					atvModel.PickupLocation,
					atvModel.DeliveryLocation,
					atvModel.CollectionDateEarliest,
					atvModel.CollectionDateLatest,
					atvModel.DeliveryDateEarliest,
					atvModel.DeliveryDateLatest,
					photoPaths,
					atvModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{atv.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Cars/Create")]
		public IActionResult CreateCar() => View();

		[HttpPost]
		[Route("Cars/Create")]
		public async Task<IActionResult> CreateCar(CarFormModel carModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (carModel.Photos != null && carModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in carModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Car car = this.vehicleService.CreateCar(
					carModel.Title,
					carModel.BodyType,
					carModel.Make,
					carModel.Model,
					carModel.State,
					carModel.PickupLocation,
					carModel.DeliveryLocation,
					carModel.CollectionDateEarliest,
					carModel.CollectionDateLatest,
					carModel.DeliveryDateEarliest,
					carModel.DeliveryDateLatest,
					carModel.ServiceType,
					photoPaths,
					carModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{car.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("HeavyVehicles/Create")]
		public IActionResult CreateHeavyVehicle() => View();

		[HttpPost]
		[Route("HeavyVehicles/Create")]
		public async Task<IActionResult> CreateHeavyVehicle(HeavyVehicleFormModel heavyVehicleModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (heavyVehicleModel.Photos != null && heavyVehicleModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in heavyVehicleModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				HeavyVehicle heavyVehicle = this.vehicleService.CreateHeavyVehicle(
					heavyVehicleModel.Type,
					heavyVehicleModel.Make,
					heavyVehicleModel.Model,
					heavyVehicleModel.Title,
					heavyVehicleModel.IsOnTrailer,
					heavyVehicleModel.PickupLocation,
					heavyVehicleModel.DeliveryLocation,
					heavyVehicleModel.OwnedTrailerType,
					heavyVehicleModel.TrailerType,
					heavyVehicleModel.CollectionDateEarliest,
					heavyVehicleModel.CollectionDateLatest,
					heavyVehicleModel.DeliveryDateEarliest,
					heavyVehicleModel.DeliveryDateLatest,
					photoPaths,
					heavyVehicleModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{heavyVehicle.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Motorcycles/Create")]
		public IActionResult CreateMotorcycle() => View();

		[HttpPost]
		[Route("Motorcycles/Create")]
		public async Task<IActionResult> CreateMotorcycle(MotorcycleFormModel motorcycleModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (motorcycleModel.Photos != null && motorcycleModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in motorcycleModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Motorcycle motorcycle = this.vehicleService.CreateMotorcycle(
					motorcycleModel.Title,
					motorcycleModel.Type,
					motorcycleModel.Make,
					motorcycleModel.Model,
					motorcycleModel.State,
					motorcycleModel.PickupLocation,
					motorcycleModel.DeliveryLocation,
					motorcycleModel.CollectionDateEarliest,
					motorcycleModel.CollectionDateLatest,
					motorcycleModel.DeliveryDateEarliest,
					motorcycleModel.DeliveryDateLatest,
					motorcycleModel.ServiceType,
					photoPaths,
					motorcycleModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{motorcycle.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("RecreationalVehicles/Create")]
		public IActionResult CreateRecreationalVehicle() => View();

		[HttpPost]
		[Route("RecreationalVehicles/Create")]
		public async Task<IActionResult> CreateRecreationalVehicle(RecreationalVehicleFormModel recreationalVehicleModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (recreationalVehicleModel.Photos != null && recreationalVehicleModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in recreationalVehicleModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				RecreationalVehicle recreationalVehicle = this.vehicleService.CreateRecreationalVehicle(
					recreationalVehicleModel.Title,
					recreationalVehicleModel.Type,
					recreationalVehicleModel.Year,
					recreationalVehicleModel.Make,
					recreationalVehicleModel.Model,
					recreationalVehicleModel.MeasurementUnit,
					recreationalVehicleModel.LengthFirstPart,
					recreationalVehicleModel.LengthSecondPart,
					recreationalVehicleModel.WidthFirstPart,
					recreationalVehicleModel.WidthSecondPart,
					recreationalVehicleModel.HeightFirstPart,
					recreationalVehicleModel.WidthSecondPart,
					recreationalVehicleModel.Weight,
					recreationalVehicleModel.PickupLocation,
					recreationalVehicleModel.DeliveryLocation,
					recreationalVehicleModel.CanBeDriven,
					recreationalVehicleModel.CollectionDateEarliest,
					recreationalVehicleModel.CollectionDateLatest,
					recreationalVehicleModel.DeliveryDateEarliest,
					recreationalVehicleModel.DeliveryDateLatest,
					photoPaths,
					recreationalVehicleModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{recreationalVehicle.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("ATVS/{id}")]
		public IActionResult ATVDetails(int id)
		{
			ATVDetailsServiceModel atvServiceModel = this.vehicleService.ATVDetails(id);

			ATVDetailsViewModel atvViewModel = new ATVDetailsViewModel
			{
				Id = atvServiceModel.Id,
				Title = atvServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = atvServiceModel.PickupLocation,
					DeliveryLocation = atvServiceModel.DeliveryLocation,
					CollectionDateEarliest = atvServiceModel.CollectionDateEarliest,
					CollectionDateLatest = atvServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = atvServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = atvServiceModel.DeliveryDateLatest,
				},
				ItemDescription = atvServiceModel.ItemDescription,
				LengthFirstPart = atvServiceModel.LengthFirstPart,
				LengthSecondPart = atvServiceModel.LengthSecondPart,
				WidthFirstPart = atvServiceModel.WidthFirstPart,
				WidthSecondPart = atvServiceModel.WidthSecondPart,
				HeightFirstPart = atvServiceModel.HeightFirstPart,
				HeightSecondPart = atvServiceModel.HeightSecondPart,
				Weight = atvServiceModel.Weight,
				Photos = atvServiceModel.Photos,
				Bids = atvServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				MeasurementUnit = atvServiceModel.MeasurementUnit,
				AdditionalDetails = atvServiceModel.AdditionalDetails,
			};

			return View(atvViewModel);
		}

		[Route("Cars/{id}")]
		public IActionResult CarDetails(int id)
		{
			CarDetailsServiceModel carServiceModel = this.vehicleService.CarDetails(id);

			CarDetailsViewModel carViewModel = new CarDetailsViewModel
			{
				Id = carServiceModel.Id,
				Title = carServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = carServiceModel.PickupLocation,
					DeliveryLocation = carServiceModel.DeliveryLocation,
					CollectionDateEarliest = carServiceModel.CollectionDateEarliest,
					CollectionDateLatest = carServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = carServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = carServiceModel.DeliveryDateLatest,
				},
				BodyType = carServiceModel.BodyType,
				Make = carServiceModel.Make,
				Model = carServiceModel.Model,
				State = carServiceModel.State,
				Photos = carServiceModel.Photos,
				Bids = carServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				ServiceType = carServiceModel.ServiceType,
				AdditionalDetails = carServiceModel.AdditionalDetails,
			};

			return View(carViewModel);
		}

		[Route("HeavyVehicles/{id}")]
		public IActionResult HeavyVehicleDetails(int id)
		{
			HeavyVehicleDetailsServiceModel heavyVehicleServiceModel = this.vehicleService.HeavyVehicleDetails(id);

			HeavyVehicleDetailsViewModel heavyVehicleViewModel = new HeavyVehicleDetailsViewModel
			{
				Id = heavyVehicleServiceModel.Id,
				Title = heavyVehicleServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = heavyVehicleServiceModel.PickupLocation,
					DeliveryLocation = heavyVehicleServiceModel.DeliveryLocation,
					CollectionDateEarliest = heavyVehicleServiceModel.CollectionDateEarliest,
					CollectionDateLatest = heavyVehicleServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = heavyVehicleServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = heavyVehicleServiceModel.DeliveryDateLatest,
				},
				Type = heavyVehicleServiceModel.Type,
				Make = heavyVehicleServiceModel.Make,
				Model = heavyVehicleServiceModel.Model,
				IsOnTrailer = heavyVehicleServiceModel.IsOnTrailer,
				OwnedTrailerType = heavyVehicleServiceModel.OwnedTrailerType,
				TrailerType = heavyVehicleServiceModel.TrailerType,
				Photos = heavyVehicleServiceModel.Photos,
				Bids = heavyVehicleServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = heavyVehicleServiceModel.AdditionalDetails,
			};

			return View(heavyVehicleViewModel);
		}

		[Route("Motorcycles/{id}")]
		public IActionResult MotorcycleDetails(int id)
		{
			MotorcycleDetailsServiceModel motorcycleServiceModel = this.vehicleService.MotorcycleDetails(id);

			MotorcycleDetailsViewModel motorcycleViewModel = new MotorcycleDetailsViewModel
			{
				Id = motorcycleServiceModel.Id,
				Title = motorcycleServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = motorcycleServiceModel.PickupLocation,
					DeliveryLocation = motorcycleServiceModel.DeliveryLocation,
					CollectionDateEarliest = motorcycleServiceModel.CollectionDateEarliest,
					CollectionDateLatest = motorcycleServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = motorcycleServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = motorcycleServiceModel.DeliveryDateLatest,
				},
				Type = motorcycleServiceModel.Type,
				Make = motorcycleServiceModel.Make,
				Model = motorcycleServiceModel.Model,
				State = motorcycleServiceModel.State,
				ServiceType = motorcycleServiceModel.ServiceType,
				Photos = motorcycleServiceModel.Photos,
				Bids = motorcycleServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = motorcycleServiceModel.AdditionalDetails,
			};

			return View(motorcycleViewModel);
		}

		[Route("RecreationalVehicles/{id}")]
		public IActionResult RecreationalVehicleDetails(int id)
		{
			RecreationalVehicleDetailsServiceModel recreationalVehicleServiceModel = this.vehicleService.RecreationalVehicleDetails(id);

			RecreationalVehicleDetailsViewModel recreationalVehicleViewModel = new RecreationalVehicleDetailsViewModel
			{
				Id = recreationalVehicleServiceModel.Id,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = recreationalVehicleServiceModel.PickupLocation,
					DeliveryLocation = recreationalVehicleServiceModel.DeliveryLocation,
					CollectionDateEarliest = recreationalVehicleServiceModel.CollectionDateEarliest,
					CollectionDateLatest = recreationalVehicleServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = recreationalVehicleServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = recreationalVehicleServiceModel.DeliveryDateLatest,
				},
				Type = recreationalVehicleServiceModel.Type,
				Year = recreationalVehicleServiceModel.Year,
				Make = recreationalVehicleServiceModel.Make,
				Model = recreationalVehicleServiceModel.Model,
				MeasurementUnit = recreationalVehicleServiceModel.MeasurementUnit,
				LengthFirstPart = recreationalVehicleServiceModel.LengthFirstPart,
				LengthSecondPart = recreationalVehicleServiceModel.LengthSecondPart,
				WidthFirstPart = recreationalVehicleServiceModel.WidthFirstPart,
				WidthSecondPart = recreationalVehicleServiceModel.WidthSecondPart,
				HeightFirstPart = recreationalVehicleServiceModel.HeightFirstPart,
				HeightSecondPart = recreationalVehicleServiceModel.HeightSecondPart,
				Weight = recreationalVehicleServiceModel.Weight,
				CanBeDriven = recreationalVehicleServiceModel.CanBeDriven,
				Description = recreationalVehicleServiceModel.Description,
				Photos = recreationalVehicleServiceModel.Photos,
				Bids = recreationalVehicleServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = recreationalVehicleServiceModel.AdditionalDetails,
			};

			return View(recreationalVehicleViewModel);
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