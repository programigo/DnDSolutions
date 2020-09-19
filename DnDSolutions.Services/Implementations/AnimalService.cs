using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Animals;
using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Services.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
	public class AnimalService : IAnimalService
	{
		private readonly DnDSolutionsDbContext db;
		private readonly IConfigurationProvider provider;

		public AnimalService(DnDSolutionsDbContext db, IConfigurationProvider provider)
		{
			this.db = db;
			this.provider = provider;
		}

		public IEnumerable<CatListingServiceModel> AllCats(int page = 1)
			=> this.db
				.Cats
				.OrderByDescending(c => c.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<CatListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<DogListingServiceModel> AllDogs(int page = 1)
			=> this.db
				.Dogs
				.OrderByDescending(d => d.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<DogListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<HorseListingServiceModel> AllHorses(int page = 1)
			=> this.db
				.Horses
				.OrderByDescending(h => h.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<HorseListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<LivestockListingServiceModel> AllLivestock(int page = 1)
			=> this.db
				.Livestock
				.OrderByDescending(ls => ls.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<LivestockListingServiceModel>(this.provider)
				.ToList();

		public int TotalCats() => this.db.Cats.Count();

		public int TotalDogs() => this.db.Dogs.Count();

		public int TotalHorses() => this.db.Horses.Count();

		public int TotalLivestock() => this.db.Livestock.Count();

		public Cat CreateCat(
			int count,
			string deliveryTitle,
			string name,
			string breed,
			int weight,
			bool hasAllVaccinations,
			bool hasCarrier,
			bool hasSpecificNeeds,
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
			Cat cat = new Cat
			{
				Count = count,
				Title = deliveryTitle,
				Name = name,
				Breed = breed,
				Weight = weight,
				HasAllVaccinations = hasAllVaccinations,
				HasCarrier = hasCarrier,
				HasSpecificNeeds = hasSpecificNeeds,
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

			this.db.Add(cat);

			this.db.SaveChanges();

			this.SavePhotos(cat.Id, photoPaths);

			return cat;
		}

		public Dog CreateDog(
			int count,
			string deliveryTitle,
			string name,
			string breed,
			int weight,
			bool hasAllVaccinations,
			bool hasCarrier,
			bool hasSpecificNeeds,
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
			Dog dog = new Dog
			{
				Count = count,
				Title = deliveryTitle,
				Name = name,
				Breed = breed,
				Weight = weight,
				HasAllVaccinations = hasAllVaccinations,
				HasCarrier = hasCarrier,
				HasSpecificNeeds = hasSpecificNeeds,
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

			this.db.Add(dog);

			this.db.SaveChanges();

			this.SavePhotos(dog.Id, photoPaths);

			return dog;
		}

		public Horse CreateHorse(
			int count,
			string deliveryTitle,
			HorseBreed breed,
			int weight,
			int height,
			string name,
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
			Horse horse = new Horse
			{
				Count = count,
				Title = deliveryTitle,
				Breed = breed,
				Weight = weight,
				Height = height,
				Name = name,
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

			this.db.Add(horse);

			this.db.SaveChanges();

			this.SavePhotos(horse.Id, photoPaths);

			return horse;
		}

		public Livestock CreateLivestock(
			string deliveryTitle,
			string breed,
			int totalWeight,
			int count,
			bool hasAllVaccinations,
			bool hasAllTags,
			bool hasSpecificNeeds,
			bool isInCorral,
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
			Livestock livestock = new Livestock
			{
				Title = deliveryTitle,
				Breed = breed,
				TotalWeight = totalWeight,
				Count = count,
				HasAllVaccinations = hasAllVaccinations,
				HasAllTags = hasAllTags,
				HasSpecificNeeds = hasSpecificNeeds,
				IsInCorral = isInCorral,
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

			this.db.Add(livestock);

			this.db.SaveChanges();

			this.SavePhotos(livestock.Id, photoPaths);

			return livestock;
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

		public CatDetailsServiceModel CatDetails(int id)
			=> this.db
			.Cats
			.Where(c => c.Id == id)
			.ProjectTo<CatDetailsServiceModel>(this.provider)
			.FirstOrDefault();

		public DogDetailsServiceModel DogDetails(int id)
			=> this.db
				.Dogs
				.Where(d => d.Id == id)
				.ProjectTo<DogDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public HorseDetailsServiceModel HorseDetails(int id)
			=> this.db
				.Horses
				.Where(h => h.Id == id)
				.ProjectTo<HorseDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public LivestockDetailsServiceModel LivestockDetails(int id)
			=> this.db
				.Livestock
				.Where(ls => ls.Id == id)
				.ProjectTo<LivestockDetailsServiceModel>(this.provider)
				.FirstOrDefault();
	}
}
