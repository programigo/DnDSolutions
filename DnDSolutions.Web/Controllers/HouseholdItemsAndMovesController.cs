using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using DnDSolutions.Services;
using DnDSolutions.Services.Models.HouseholdItemsAndMoves;
using DnDSolutions.Web.Models;
using DnDSolutions.Web.Models.Bids;
using DnDSolutions.Web.Models.HouseholdItemsAndMoves;
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
	[Route("household-items-and-moves")]
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.CustomerRole)]
	public class HouseholdItemsAndMovesController : Controller
	{
		private UserManager<User> userManager;
		private readonly IHouseholdItemsAndMovesService householdItemsAndMovesService;
		private readonly IWebHostEnvironment hostingEnvironment;
		private readonly IEmailSender emailSender;

		public HouseholdItemsAndMovesController(UserManager<User> userManager, IHouseholdItemsAndMovesService householdItemsAndMovesService, IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
		{
			this.userManager = userManager;
			this.householdItemsAndMovesService = householdItemsAndMovesService;
			this.hostingEnvironment = hostingEnvironment;
			this.emailSender = emailSender;
		}

		public IActionResult Index() => View();

		[Route("Arts/Create")]
		public IActionResult CreateArt() => View();

		[HttpPost]
		[Route("Arts/Create")]
		public async Task<IActionResult> CreateArt(ArtFormModel artModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (artModel.Photos != null && artModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in artModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Art art = this.householdItemsAndMovesService.CreateArt(
					artModel.Type,
					artModel.Title,
					artModel.MeasurementUnit,
					artModel.LengthFirstPart,
					artModel.LengthSecondPart,
					artModel.WidthFirstPart,
					artModel.WidthSecondPart,
					artModel.HeightFirstPart,
					artModel.HeightSecondPart,
					artModel.Weight,
					artModel.Description,
					artModel.Packaging,
					artModel.SpecialHandling,
					artModel.PickupLocation,
					artModel.DeliveryLocation,
					artModel.CollectionDateEarliest,
					artModel.CollectionDateLatest,
					artModel.DeliveryDateEarliest,
					artModel.DeliveryDateLatest,
					photoPaths,
					artModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{art.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("household-items/Create")]
		public IActionResult CreateHouseholdItem() => View();

		[HttpPost]
		[Route("household-items/Create")]
		public async Task<IActionResult> CreateHouseholdItem(HouseholdItemFormModel householdItemModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (householdItemModel.Photos != null && householdItemModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in householdItemModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				HouseholdItem householdItem = this.householdItemsAndMovesService.CreateHouseholdItem(
					householdItemModel.NumberOfItems,
					householdItemModel.Type,
					householdItemModel.Title,
					householdItemModel.MeasurementUnit,
					householdItemModel.LengthFirstPart,
					householdItemModel.LengthSecondPart,
					householdItemModel.WidthFirstPart,
					householdItemModel.WidthSecondPart,
					householdItemModel.HeightFirstPart,
					householdItemModel.HeightSecondPart,
					householdItemModel.Weight,
					householdItemModel.IsPalletised,
					householdItemModel.IsCrated,
					householdItemModel.IsStickable,
					householdItemModel.PickupLocation,
					householdItemModel.DeliveryLocation,
					householdItemModel.CollectionDateEarliest,
					householdItemModel.CollectionDateLatest,
					householdItemModel.DeliveryDateEarliest,
					householdItemModel.DeliveryDateLatest,
					photoPaths,
					householdItemModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{householdItem.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Moves/Create")]
		public IActionResult CreateMove() => View();

		[HttpPost]
		[Route("Moves/Create")]
		public async Task<IActionResult> CreateMove(MoveFormModel moveModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (moveModel.Photos != null && moveModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in moveModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Move move = this.householdItemsAndMovesService.CreateMove(
					moveModel.Type,
					moveModel.Title,
					moveModel.PickupLocation,
					moveModel.DeliveryLocation,
					moveModel.CollectionDateEarliest,
					moveModel.CollectionDateLatest,
					moveModel.DeliveryDateEarliest,
					moveModel.DeliveryDateLatest,
					photoPaths,
					moveModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{move.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Pianos/Create")]
		public IActionResult CreatePiano() => View();

		[HttpPost]
		[Route("Pianos/Create")]
		public async Task<IActionResult> CreatePiano(PianoFormModel pianoModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (pianoModel.Photos != null && pianoModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in pianoModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Piano piano = this.householdItemsAndMovesService.CreatePiano(
					pianoModel.Title,
					pianoModel.Type,
					pianoModel.VerticalType,
					pianoModel.HorizontalType,
					pianoModel.IsOnCasters,
					pianoModel.PickupLocation,
					pianoModel.DeliveryLocation,
					pianoModel.CollectionDateEarliest,
					pianoModel.CollectionDateLatest,
					pianoModel.DeliveryDateEarliest,
					pianoModel.DeliveryDateLatest,
					photoPaths,
					pianoModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{piano.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Offices/Create")]
		public IActionResult CreateOffice() => View();

		[HttpPost]
		[Route("Offices/Create")]
		public async Task<IActionResult> CreateOffice(OfficeFormModel officeModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (officeModel.Photos != null && officeModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in officeModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Office office = this.householdItemsAndMovesService.CreateOffice(
					officeModel.CollectionFloor,
					officeModel.HasCollectionFloorElevator,
					officeModel.DeliveryFloor,
					officeModel.HasDeliveryFloorElevator,
					officeModel.HasDisassemblyItems,
					officeModel.HasReassemblyItems,
					officeModel.Title,
					officeModel.PickupLocation,
					officeModel.DeliveryLocation,
					officeModel.CollectionDateEarliest,
					officeModel.CollectionDateLatest,
					officeModel.DeliveryDateEarliest,
					officeModel.DeliveryDateLatest,
					photoPaths,
					officeModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Deliveries/{office.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Arts/{id}")]
		public IActionResult ArtDetails(int id)
		{
			ArtDetailsServiceModel artServiceModel = this.householdItemsAndMovesService.ArtDetails(id);

			ArtDetailsViewModel artViewModel = new ArtDetailsViewModel
			{
				Id = artServiceModel.Id,
				Title = artServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = artServiceModel.PickupLocation,
					DeliveryLocation = artServiceModel.DeliveryLocation,
					CollectionDateEarliest = artServiceModel.CollectionDateEarliest,
					CollectionDateLatest = artServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = artServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = artServiceModel.DeliveryDateLatest,
				},
				Type = artServiceModel.Type,
				Description = artServiceModel.Description,
				Packaging = artServiceModel.Packaging,
				SpecialHandling = artServiceModel.SpecialHandling,
				MeasurementUnit = artServiceModel.MeasurementUnit,
				LengthFirstPart = artServiceModel.LengthFirstPart,
				LengthSecondPart = artServiceModel.LengthSecondPart,
				WidthFirstPart = artServiceModel.WidthFirstPart,
				WidthSecondPart = artServiceModel.WidthSecondPart,
				HeightFirstPart = artServiceModel.HeightFirstPart,
				HeightSecondPart = artServiceModel.HeightSecondPart,
				Weight = artServiceModel.Weight,
				Photos = artServiceModel.Photos,
				Bids = artServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = artServiceModel.AdditionalDetails,
			};

			return View(artViewModel);
		}

		[Route("HouseholdItems/{id}")]
		public IActionResult HouseholdItemDetails(int id)
		{
			HouseholdItemDetailsServiceModel householdServiceModel = this.householdItemsAndMovesService.HouseholdItemDetails(id);

			HouseholdItemDetailsViewModel householdViewModel = new HouseholdItemDetailsViewModel
			{
				Id = householdServiceModel.Id,
				Title = householdServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = householdServiceModel.PickupLocation,
					DeliveryLocation = householdServiceModel.DeliveryLocation,
					CollectionDateEarliest = householdServiceModel.CollectionDateEarliest,
					CollectionDateLatest = householdServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = householdServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = householdServiceModel.DeliveryDateLatest,
				},
				NumberOfItems = householdServiceModel.NumberOfItems,
				Type = householdServiceModel.Type,
				IsPalletised = householdServiceModel.IsPalletised,
				IsCrated = householdServiceModel.IsCrated,
				IsStickable = householdServiceModel.IsStickable,
				MeasurementUnit = householdServiceModel.MeasurementUnit,
				LengthFirstPart = householdServiceModel.LengthFirstPart,
				LengthSecondPart = householdServiceModel.LengthSecondPart,
				WidthFirstPart = householdServiceModel.WidthFirstPart,
				WidthSecondPart = householdServiceModel.WidthSecondPart,
				HeightFirstPart = householdServiceModel.HeightFirstPart,
				HeightSecondPart = householdServiceModel.HeightSecondPart,
				Weight = householdServiceModel.Weight,
				Photos = householdServiceModel.Photos,
				Bids = householdServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = householdServiceModel.AdditionalDetails,
			};

			return View(householdViewModel);
		}

		[Route("Moves/{id}")]
		public IActionResult MoveDetails(int id)
		{
			MoveDetailsServiceModel moveServiceModel = this.householdItemsAndMovesService.MoveDetails(id);

			MoveDetailsViewModel moveViewModel = new MoveDetailsViewModel
			{
				Id = moveServiceModel.Id,
				Title = moveServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = moveServiceModel.PickupLocation,
					DeliveryLocation = moveServiceModel.DeliveryLocation,
					CollectionDateEarliest = moveServiceModel.CollectionDateEarliest,
					CollectionDateLatest = moveServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = moveServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = moveServiceModel.DeliveryDateLatest,
				},
				Type = moveServiceModel.Type,
				AdditionalDetails = moveServiceModel.AdditionalDetails,
				Photos = moveServiceModel.Photos,
				Bids = moveServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
			};

			return View(moveViewModel);
		}

		[Route("Pianos/{id}")]
		public IActionResult PianoDetails(int id)
		{
			PianoDetailsServiceModel pianoServiceModel = this.householdItemsAndMovesService.PianoDetails(id);

			PianoDetailsViewModel pianoViewModel = new PianoDetailsViewModel
			{
				Id = pianoServiceModel.Id,
				Title = pianoServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = pianoServiceModel.PickupLocation,
					DeliveryLocation = pianoServiceModel.DeliveryLocation,
					CollectionDateEarliest = pianoServiceModel.CollectionDateEarliest,
					CollectionDateLatest = pianoServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = pianoServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = pianoServiceModel.DeliveryDateLatest,
				},
				Type = pianoServiceModel.Type,
				VerticalType = pianoServiceModel.VerticalType,
				HorizontalType = pianoServiceModel.HorizontalType,
				IsOnCasters = pianoServiceModel.IsOnCasters,
				Photos = pianoServiceModel.Photos,
				Bids = pianoServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = pianoServiceModel.AdditionalDetails
			};

			return View(pianoViewModel);
		}

		[Route("Offices/{id}")]
		public IActionResult OfficeDetails(int id)
		{
			OfficeDetailsServiceModel officeServiceModel = this.householdItemsAndMovesService.OfficeDetails(id);

			OfficeDetailsViewModel officeViewModel = new OfficeDetailsViewModel
			{
				Id = officeServiceModel.Id,
				Title = officeServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = officeServiceModel.PickupLocation,
					DeliveryLocation = officeServiceModel.DeliveryLocation,
					CollectionDateEarliest = officeServiceModel.CollectionDateEarliest,
					CollectionDateLatest = officeServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = officeServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = officeServiceModel.DeliveryDateLatest,
				},
				AdditionalDetails = officeServiceModel.AdditionalDetails,
				CollectionFloor = officeServiceModel.CollectionFloor,
				HasCollectionFloorElevator = officeServiceModel.HasCollectionFloorElevator,
				DeliveryFloor = officeServiceModel.DeliveryFloor,
				HasDeliveryFloorElevator = officeServiceModel.HasDeliveryFloorElevator,
				HasDisassemblyItems = officeServiceModel.HasDisassemblyItems,
				HasReassemblyItems = officeServiceModel.HasReassemblyItems,
				Photos = officeServiceModel.Photos,
				Bids = officeServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
			};

			return View(officeViewModel);
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

