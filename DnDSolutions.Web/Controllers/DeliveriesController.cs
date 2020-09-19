using DnDSolutions.Services;
using DnDSolutions.Web.Models.Animals;
using DnDSolutions.Web.Models.Boats;
using DnDSolutions.Web.Models.Freights;
using DnDSolutions.Web.Models.HouseholdItemsAndMoves;
using DnDSolutions.Web.Models.Vehicles;
using Microsoft.AspNetCore.Mvc;

namespace DnDSolutions.Web.Controllers
{
	public class DeliveriesController : Controller
	{
		private readonly IAnimalService animalService;
		private readonly IBoatService boatService;
		private readonly IFreightService freightService;
		private readonly IHouseholdItemsAndMovesService householdItemsAndMovesService;
		private readonly IVehicleService vehicleService;

		public DeliveriesController(
			IAnimalService animalService,
			IBoatService boatService,
			IFreightService freightService,
			IHouseholdItemsAndMovesService householdItemsAndMovesService,
			IVehicleService vehicleService)
		{
			this.animalService = animalService;
			this.boatService = boatService;
			this.freightService = freightService;
			this.householdItemsAndMovesService = householdItemsAndMovesService;
			this.vehicleService = vehicleService;
		}

		public IActionResult Index() => View();

		public IActionResult Animals(int page = 1)
			=> View(new AnimalListingViewModel
			{
				Cats = this.animalService.AllCats(page),
				Dogs = this.animalService.AllDogs(page),
				Horses = this.animalService.AllHorses(page),
				Livestock = this.animalService.AllLivestock(page),
				TotalAnimals =
				  this.animalService.TotalCats()
				+ this.animalService.TotalDogs()
				+ this.animalService.TotalHorses()
				+ this.animalService.TotalLivestock(),
				CurrentPage = page,
			});

		public IActionResult Cats(int page = 1)
			=> View(new CatListingViewModel
			{
				Cats = this.animalService.AllCats(page),
				TotalCats = this.animalService.TotalCats(),
				CurrentPage = page,
			});

		public IActionResult Dogs(int page = 1)
			=> View(new DogListingViewModel
			{
				Dogs = this.animalService.AllDogs(page),
				TotalDogs = this.animalService.TotalDogs(),
				CurrentPage = page,
			});

		public IActionResult Horses(int page = 1)
			=> View(new HorseListingViewModel
			{
				Horses = this.animalService.AllHorses(page),
				TotalHorses = this.animalService.TotalHorses(),
				CurrentPage = page,
			});

		public IActionResult Livestock(int page = 1)
			=> View(new LivestockListingViewModel
			{
				Livestock = this.animalService.AllLivestock(page),
				TotalLivestock = this.animalService.TotalLivestock(),
				CurrentPage = page,
			});

		public IActionResult Boats(int page = 1)
			=> View(new BoatListingViewModel
			{
				Boats = this.boatService.AllBoats(page),
				TotalBoats = this.boatService.TotalBoats(),
				CurrentPage = page,
			});

		public IActionResult LessThanContainerLoads(int page = 1)
			=> View(new LessThanContainerLoadListingViewModel
			{
				LCLs = this.freightService.AllLCLs(page),
				TotalLCLs = this.freightService.TotalLCLs(),
				CurrentPage = page,
			});

		public IActionResult Arts(int page = 1)
			=> View(new ArtListingViewModel
			{
				Arts = this.householdItemsAndMovesService.AllArts(page),
				TotalArts = this.householdItemsAndMovesService.TotalArts(),
				CurrentPage = page,
			});

		public IActionResult Moves(int page = 1)
			=> View(new MovesListingViewModel
			{
				Moves = this.householdItemsAndMovesService.AllMoves(page),
				TotalMoves = this.householdItemsAndMovesService.TotalMoves(),
				CurrentPage = page,
			});

		public IActionResult Offices(int page = 1)
			=> View(new OfficeListingViewModel
			{
				Offices = this.householdItemsAndMovesService.AllOffices(page),
				TotalOffices = this.householdItemsAndMovesService.TotalOffices(),
				CurrentPage = page,
			});

		public IActionResult Pianos(int page = 1)
			=> View(new PianoListingViewModel
			{
				Pianos = this.householdItemsAndMovesService.AllPianos(page),
				TotalPianos = this.householdItemsAndMovesService.TotalPianos(),
				CurrentPage = page,
			});

		public IActionResult HouseholdItems(int page = 1)
			=> View(new HouseholdItemListingViewModel
			{
				HouseholdItems = this.householdItemsAndMovesService.AllHouseholdItems(page),
				TotalHouseholdItems = this.householdItemsAndMovesService.TotalHouseholdItems(),
				CurrentPage = page,
			});

		public IActionResult ATVs(int page = 1)
			=> View(new ATVListingViewModel
			{
				ATVs = this.vehicleService.AllATVs(page),
				TotalATVs = this.vehicleService.TotalATVs(),
				CurrentPage = page,
			});

		public IActionResult Cars(int page = 1)
			=> View(new CarListingViewModel
			{
				Cars = this.vehicleService.AllCars(page),
				TotalCars = this.vehicleService.TotalCars(),
				CurrentPage = page,
			});

		public IActionResult HeavyVehicles(int page = 1)
			=> View(new HeavyVehicleListingViewModel
			{
				HeavyVehicles = this.vehicleService.AllHeavyVehicles(page),
				TotalHeavyVehicles = this.vehicleService.TotalHeavyVehicles(),
				CurrentPage = page,
			});

		public IActionResult Motorcycles(int page = 1)
			=> View(new MotorcycleListingViewModel
			{
				Motorcycles = this.vehicleService.AllMotorcycles(page),
				TotalMotorcycles = this.vehicleService.TotalMotorcycles(),
				CurrentPage = page,
			});

		public IActionResult RecreationalVehicles(int page = 1)
			=> View(new RecreationalVehicleListingViewModel
			{
				RecreationalVehicles = this.vehicleService.AllRecreationalVehicles(page),
				TotalRecreationalVehicles = this.vehicleService.TotalRecreationalVehicles(),
				CurrentPage = page,
			});
	}
}