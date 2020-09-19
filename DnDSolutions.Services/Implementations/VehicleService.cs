using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Services.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
	public class VehicleService : IVehicleService
	{
		private readonly DnDSolutionsDbContext db;
		private readonly IConfigurationProvider provider;

		public VehicleService(DnDSolutionsDbContext db, IConfigurationProvider provider)
		{
			this.db = db;
			this.provider = provider;
		}

		public IEnumerable<ATVListingServiceModel> AllATVs(int page = 1)
			=> this.db
				.ATVs
				.OrderByDescending(a => a.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<ATVListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<CarListingServiceModel> AllCars(int page = 1)
			=> this.db
				.Cars
				.OrderByDescending(c => c.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<CarListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<HeavyVehicleListingServiceModel> AllHeavyVehicles(int page = 1)
			=> this.db
				.HeavyVehicles
				.OrderByDescending(hv => hv.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<HeavyVehicleListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<MotorcycleListingServiceModel> AllMotorcycles(int page = 1)
			=> this.db
				.Motorcycles
				.OrderByDescending(m => m.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<MotorcycleListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<RecreationalVehicleListingServiceModel> AllRecreationalVehicles(int page = 1)
			=> this.db
				.RecreationalVehicles
				.OrderByDescending(rv => rv.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<RecreationalVehicleListingServiceModel>(this.provider)
				.ToList();

		public int TotalATVs() => this.db.ATVs.Count();

		public int TotalCars() => this.db.Cars.Count();

		public int TotalHeavyVehicles() => this.db.HeavyVehicles.Count();

		public int TotalMotorcycles() => this.db.Motorcycles.Count();

		public int TotalRecreationalVehicles() => this.db.RecreationalVehicles.Count();

		public ATV CreateATV(
			string deliveryTitle,
			string itemDescription,
			MeasurementUnit measurementUnit,
			int lengthFirstPart,
			int? lengthSecondPart,
			int widthFirstPart,
			int? widthSecondPart,
			int heightFirstPart,
			int? heightSecondPart,
			int weight,
			string pickupLocation,
			string deliveryLocation,
			DateTime collectionDateEarliest,
			DateTime collectionDateLatest,
			DateTime deliveryDateEarliest,
			DateTime deliveryDateLatest,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId)
		{
			ATV atv = new ATV
			{
				Title = deliveryTitle,
				ItemDescription = itemDescription,
				MeasurementUnit = measurementUnit,
				LengthFirstPart = lengthFirstPart,
				LengthSecondPart = lengthSecondPart,
				WidthFirstPart = widthFirstPart,
				WidthSecondPart = widthSecondPart,
				HeightFirstPart = heightFirstPart,
				HeightSecondPart = heightSecondPart,
				Weight = weight,
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				CollectionDateEarliest = collectionDateEarliest,
				CollectionDateLatest = collectionDateLatest,
				DeliveryDateEarliest = deliveryDateEarliest,
				DeliveryDateLatest = deliveryDateLatest,
				AdditionalDetails = additionalDetails,
				CreateDate = createDate,
				UserId = userId,
			};

			this.db.Add(atv);

			this.db.SaveChanges();

			this.SavePhotos(atv.Id, photoPaths);

			return atv;
		}

		public Car CreateCar(
			string deliveryTitle,
			CarBodyType bodyType,
			string make,
			string model,
			IEnumerable<CarState> states,
			string pickupLocation,
			string deliveryLocation,
			DateTime collectionDateEarliest,
			DateTime collectionDateLatest,
			DateTime deliveryDateEarliest,
			DateTime deliveryDateLatest,
			ServiceType serviceType,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId)
		{
			Car car = new Car
			{
				Title = deliveryTitle,
				BodyType = bodyType,
				Make = make,
				Model = model,
				State = (CarState)states.Cast<int>().Sum(),
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				CollectionDateEarliest = collectionDateEarliest,
				CollectionDateLatest = collectionDateLatest,
				DeliveryDateEarliest = deliveryDateEarliest,
				DeliveryDateLatest = deliveryDateLatest,
				ServiceType = serviceType,
				AdditionalDetails = additionalDetails,
				CreateDate = createDate,
				UserId = userId,
			};

			this.db.Add(car);

			this.db.SaveChanges();

			this.SavePhotos(car.Id, photoPaths);

			return car;
		}

		public HeavyVehicle CreateHeavyVehicle(
			HeavyVehicleType type,
			string make,
			string model,
			string deliveryTitle,
			bool isOnTrailer,
			string pickupLocation,
			string deliveryLocation,
			HeavyVehicleOwnedTrailerType ownedTrailerType,
			IEnumerable<HeavyVehicleTrailerType> trailerTypes,
			DateTime collectionDateEarliest,
			DateTime collectionDateLatest,
			DateTime deliveryDateEarliest,
			DateTime deliveryDateLatest,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId)
		{
			HeavyVehicle heavyVehicle = new HeavyVehicle
			{
				Type = type,
				Make = make,
				Model = model,
				Title = deliveryTitle,
				IsOnTrailer = isOnTrailer,
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				OwnedTrailerType = ownedTrailerType,
				TrailerType = (HeavyVehicleTrailerType)trailerTypes.Cast<int>().Sum(),
				CollectionDateEarliest = collectionDateEarliest,
				CollectionDateLatest = collectionDateLatest,
				DeliveryDateEarliest = deliveryDateEarliest,
				DeliveryDateLatest = deliveryDateLatest,
				AdditionalDetails = additionalDetails,
				CreateDate = createDate,
				UserId = userId,
			};

			this.db.Add(heavyVehicle);

			this.db.SaveChanges();

			this.SavePhotos(heavyVehicle.Id, photoPaths);

			return heavyVehicle;
		}

		public Motorcycle CreateMotorcycle(
			string deliveryTitle,
			MotorcycleType type,
			string make,
			string model,
			IEnumerable<MotorcycleState> states,
			string pickupLocation,
			string deliveryLocation,
			DateTime collectionDateEarliest,
			DateTime collectionDateLatest,
			DateTime deliveryDateEarliest,
			DateTime deliveryDateLatest,
			ServiceType serviceType,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId)
		{
			Motorcycle motorcycle = new Motorcycle
			{
				Title = deliveryTitle,
				Type = type,
				Make = make,
				Model = model,
				State = (MotorcycleState)states.Cast<int>().Sum(),
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				CollectionDateEarliest = collectionDateEarliest,
				CollectionDateLatest = collectionDateLatest,
				DeliveryDateEarliest = deliveryDateEarliest,
				DeliveryDateLatest = deliveryDateLatest,
				ServiceType = serviceType,
				AdditionalDetails = additionalDetails,
				CreateDate = createDate,
				UserId = userId,
			};

			this.db.Add(motorcycle);

			this.db.SaveChanges();

			this.SavePhotos(motorcycle.Id, photoPaths);

			return motorcycle;
		}

		public RecreationalVehicle CreateRecreationalVehicle(
			string deliveryTitle,
			CamperType type,
			int year,
			string make,
			string model,
			MeasurementUnit measurementUnit,
			int lengthFirstPart,
			int? lengthSecondPart,
			int widthFirstPart,
			int? widthSecondPart,
			int heightFirstPart,
			int? heightSecondPart,
			int weight,
			string pickupLocation,
			string deliveryLocation,
			bool? canBeDriven,
			DateTime collectionDateEarliest,
			DateTime collectionDateLatest,
			DateTime deliveryDateEarliest,
			DateTime deliveryDateLatest,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId)
		{
			RecreationalVehicle recreationalVehicle = new RecreationalVehicle
			{
				Title = deliveryTitle,
				Type = type,
				Year = year,
				Make = make,
				Model = model,
				MeasurementUnit = measurementUnit,
				LengthFirstPart = lengthFirstPart,
				LengthSecondPart = lengthSecondPart,
				WidthFirstPart = widthFirstPart,
				WidthSecondPart = widthSecondPart,
				HeightFirstPart = heightFirstPart,
				HeightSecondPart = heightSecondPart,
				Weight = weight,
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				CanBeDriven = canBeDriven,
				CollectionDateEarliest = collectionDateEarliest,
				CollectionDateLatest = collectionDateLatest,
				DeliveryDateEarliest = deliveryDateEarliest,
				DeliveryDateLatest = deliveryDateLatest,
				AdditionalDetails = additionalDetails,
				CreateDate = createDate,
				UserId = userId,
			};

			this.db.Add(recreationalVehicle);

			this.db.SaveChanges();

			this.SavePhotos(recreationalVehicle.Id, photoPaths);

			return recreationalVehicle;
		}

		private void SavePhotos(int deliveryItemId, IEnumerable<string> photoPaths)
		{
			foreach (string photoPath in photoPaths)
			{
				Photo dbPhoto = new Photo
				{
					Path = photoPath,
					DeliveryItemId = deliveryItemId,
				};

				this.db.Add(dbPhoto);

				this.db.SaveChanges();
			}
		}

		public ATVDetailsServiceModel ATVDetails(int id)
			=> this.db
				.ATVs
				.Where(a => a.Id == id)
				.ProjectTo<ATVDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public CarDetailsServiceModel CarDetails(int id)
			=> this.db
				.Cars
				.Where(c => c.Id == id)
				.ProjectTo<CarDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public HeavyVehicleDetailsServiceModel HeavyVehicleDetails(int id)
			=> this.db
				.HeavyVehicles
				.Where(hv => hv.Id == id)
				.ProjectTo<HeavyVehicleDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public MotorcycleDetailsServiceModel MotorcycleDetails(int id)
			=> this.db
				.Motorcycles
				.Where(hv => hv.Id == id)
				.ProjectTo<MotorcycleDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public RecreationalVehicleDetailsServiceModel RecreationalVehicleDetails(int id)
			=> this.db
				.RecreationalVehicles
				.Where(hv => hv.Id == id)
				.ProjectTo<RecreationalVehicleDetailsServiceModel>(this.provider)
				.FirstOrDefault();
	}
}
