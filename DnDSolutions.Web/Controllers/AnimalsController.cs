using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Animals;
using DnDSolutions.Services;
using DnDSolutions.Services.Models.Animals;
using DnDSolutions.Web.Models;
using DnDSolutions.Web.Models.Animals;
using DnDSolutions.Web.Models.Bids;
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
	[Route("animals")]
	[Authorize(Roles = GlobalConstants.AdministratorRole + ", " + GlobalConstants.CustomerRole + ", " + GlobalConstants.TransporterRole)]
	public class AnimalsController : Controller
	{
		private UserManager<User> userManager;
		private readonly IAnimalService animalService;
		private readonly IWebHostEnvironment hostingEnvironment;
		private readonly IEmailSender emailSender;

		public AnimalsController(UserManager<User> userManager, IAnimalService animalService, IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
		{
			this.userManager = userManager;
			this.animalService = animalService;
			this.hostingEnvironment = hostingEnvironment;
			this.emailSender = emailSender;
		}

		public IActionResult Index() => View();

		[Route("Cats/Create")]
		public IActionResult CreateCat() => View();

		[HttpPost]
		[Route("Cats/Create")]
		public async Task<IActionResult> CreateCat(CatFormModel catModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (catModel.Photos != null && catModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in catModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Cat cat = this.animalService.CreateCat(
					catModel.Count,
					catModel.Title,
					catModel.Name,
					catModel.Breed,
					catModel.Weight,
					catModel.HasAllVaccinations,
					catModel.HasCarrier,
					catModel.HasSpecificNeeds,
					catModel.PickupLocation,
					catModel.DeliveryLocation,
					catModel.CollectionDateEarliest,
					catModel.CollectionDateLatest,
					catModel.DeliveryDateEarliest,
					catModel.DeliveryDateLatest,
					photoPaths,
					catModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Animals/Cats/{cat.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Dogs/Create")]
		public IActionResult CreateDog() => View();

		[HttpPost]
		[Route("Dogs/Create")]
		public async Task<IActionResult> CreateDog(DogFormModel dogModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (dogModel.Photos != null && dogModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in dogModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Dog dog = this.animalService.CreateDog(
					dogModel.Count,
					dogModel.Title,
					dogModel.Name,
					dogModel.Breed,
					dogModel.Weight,
					dogModel.HasAllVaccinations,
					dogModel.HasCarrier,
					dogModel.HasSpecificNeeds,
					dogModel.PickupLocation,
					dogModel.DeliveryLocation,
					dogModel.CollectionDateEarliest,
					dogModel.CollectionDateLatest,
					dogModel.DeliveryDateEarliest,
					dogModel.DeliveryDateLatest,
					photoPaths,
					dogModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Animals/Dogs/{dog.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Horses/Create")]
		public IActionResult CreateHorse() => View();

		[HttpPost]
		[Route("Horses/Create")]
		public async Task<IActionResult> CreateHorse(HorseFormModel horseModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (horseModel.Photos != null && horseModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in horseModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Horse horse = this.animalService.CreateHorse(
					horseModel.Count,
					horseModel.Title,
					horseModel.Breed,
					horseModel.Weight,
					horseModel.Height,
					horseModel.Name,
					horseModel.PickupLocation,
					horseModel.DeliveryLocation,
					horseModel.CollectionDateEarliest,
					horseModel.CollectionDateLatest,
					horseModel.DeliveryDateEarliest,
					horseModel.DeliveryDateLatest,
					photoPaths,
					horseModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Animals/Horses/{horse.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Livestock/Create")]
		public IActionResult CreateLivestock() => View();

		[HttpPost]
		[Route("Livestock/Create")]
		public async Task<IActionResult> CreateLivestock(LivestockFormModel livestockModel)
		{
			if (ModelState.IsValid)
			{
				List<string> photoPaths = new List<string>();
				string uniqueFileName = null;
				if (livestockModel.Photos != null && livestockModel.Photos.Count > 0)
				{
					foreach (IFormFile photo in livestockModel.Photos)
					{
						string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
						uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
						photoPaths.Add(uniqueFileName);
						string filePath = Path.Combine(uploadsFolder, uniqueFileName);
						photo.CopyTo(new FileStream(filePath, FileMode.Create));
					}
				}

				Livestock livestock = this.animalService.CreateLivestock(
					livestockModel.Title,
					livestockModel.Breed,
					livestockModel.TotalWeight,
					livestockModel.Count,
					livestockModel.HasAllVaccinations,
					livestockModel.HasAllTags,
					livestockModel.HasSpecificNeeds,
					livestockModel.IsInCorral,
					livestockModel.PickupLocation,
					livestockModel.DeliveryLocation,
					livestockModel.CollectionDateEarliest,
					livestockModel.CollectionDateLatest,
					livestockModel.DeliveryDateEarliest,
					livestockModel.DeliveryDateLatest,
					photoPaths,
					livestockModel.AdditionalDetails,
					DateTime.UtcNow,
					this.userManager.GetUserId(User));

				var transporters = await userManager.GetUsersInRoleAsync(GlobalConstants.TransporterRole);

				foreach (var transporter in transporters)
				{
					await this.emailSender.SendEmailAsync(
						transporter.Email, "New delivery created", $"User {User.Identity.Name} created a new delivery. For more information visit https://localhost:5001/Animals/Livestock/{livestock.Id}");
				}

				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

			return View();
		}

		[Route("Cats/{id}")]
		public IActionResult CatDetails(int id)
		{
			CatDetailsServiceModel catServiceModel = this.animalService.CatDetails(id);

			CatDetailsViewModel catViewModel = new CatDetailsViewModel
			{
				Id = catServiceModel.Id,
				Title = catServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = catServiceModel.PickupLocation,
					DeliveryLocation = catServiceModel.DeliveryLocation,
					CollectionDateEarliest = catServiceModel.CollectionDateEarliest,
					CollectionDateLatest = catServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = catServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = catServiceModel.DeliveryDateLatest,
				},
				Count = catServiceModel.Count,
				Name = catServiceModel.Name,
				Breed = catServiceModel.Breed,
				Weight = catServiceModel.Weight,
				HasAllVaccinations = catServiceModel.HasAllVaccinations,
				HasCarrier = catServiceModel.HasCarrier,
				HasSpecificNeeds = catServiceModel.HasSpecificNeeds,
				Photos = catServiceModel.Photos,
				Bids = catServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				UserId = catServiceModel.UserId,
				Username = catServiceModel.User.UserName,
				AdditionalDetails = catServiceModel.AdditionalDetails,
			};

			return View(catViewModel);
		}


		[Route("Dogs/{id}")]

		public IActionResult DogDetails(int id)
		{
			DogDetailsServiceModel dogServiceModel = this.animalService.DogDetails(id);

			DogDetailsViewModel dogViewModel = new DogDetailsViewModel
			{
				Id = dogServiceModel.Id,
				Title = dogServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = dogServiceModel.PickupLocation,
					DeliveryLocation = dogServiceModel.DeliveryLocation,
					CollectionDateEarliest = dogServiceModel.CollectionDateEarliest,
					CollectionDateLatest = dogServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = dogServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = dogServiceModel.DeliveryDateLatest,
				},
				Count = dogServiceModel.Count,
				Name = dogServiceModel.Name,
				Breed = dogServiceModel.Breed,
				Weight = dogServiceModel.Weight,
				HasAllVaccinations = dogServiceModel.HasAllVaccinations,
				HasCarrier = dogServiceModel.HasCarrier,
				HasSpecificNeeds = dogServiceModel.HasSpecificNeeds,
				Photos = dogServiceModel.Photos,
				Bids = dogServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = dogServiceModel.AdditionalDetails,
			};

			return View(dogViewModel);
		}


		[Route("Horses/{id}")]
		public IActionResult HorseDetails(int id)
		{
			HorseDetailsServiceModel horseServiceModel = this.animalService.HorseDetails(id);

			HorseDetailsViewModel horseViewModel = new HorseDetailsViewModel
			{
				Id = horseServiceModel.Id,
				Title = horseServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = horseServiceModel.PickupLocation,
					DeliveryLocation = horseServiceModel.DeliveryLocation,
					CollectionDateEarliest = horseServiceModel.CollectionDateEarliest,
					CollectionDateLatest = horseServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = horseServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = horseServiceModel.DeliveryDateLatest,
				},
				Count = horseServiceModel.Count,
				Name = horseServiceModel.Name,
				Breed = horseServiceModel.Breed,
				Weight = horseServiceModel.Weight,
				Height = horseServiceModel.Height,
				Photos = horseServiceModel.Photos,
				Bids = horseServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = horseServiceModel.AdditionalDetails,
			};

			return View(horseViewModel);
		}

		[Route("Livestock/{id}")]
		public IActionResult LivestockDetails(int id)
		{
			LivestockDetailsServiceModel livestockServiceModel = this.animalService.LivestockDetails(id);

			LivestockDetailsViewModel livestockViewModel = new LivestockDetailsViewModel
			{
				Id = livestockServiceModel.Id,
				Title = livestockServiceModel.Title,
				RouteSummary = new RouteSummaryViewModel
				{
					PickupLocation = livestockServiceModel.PickupLocation,
					DeliveryLocation = livestockServiceModel.DeliveryLocation,
					CollectionDateEarliest = livestockServiceModel.CollectionDateEarliest,
					CollectionDateLatest = livestockServiceModel.CollectionDateLatest,
					DeliveryDateEarliest = livestockServiceModel.DeliveryDateEarliest,
					DeliveryDateLatest = livestockServiceModel.DeliveryDateLatest,
				},
				Count = livestockServiceModel.Count,
				Breed = livestockServiceModel.Breed,
				TotalWeight = livestockServiceModel.TotalWeight,
				HasAllVaccinations = livestockServiceModel.HasAllVaccinations,
				HasAllTags = livestockServiceModel.HasAllTags,
				HasSpecificNeeds = livestockServiceModel.HasSpecificNeeds,
				IsInCorral = livestockServiceModel.IsInCorral,
				Photos = livestockServiceModel.Photos,
				Bids = livestockServiceModel.Bids.Select(b => ConvertBidToViewModel(b)).ToList(),
				AdditionalDetails = livestockServiceModel.AdditionalDetails,
			};

			return View(livestockViewModel);
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
