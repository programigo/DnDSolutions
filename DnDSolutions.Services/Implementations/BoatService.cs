using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Services.Models.Boats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
	public class BoatService : IBoatService
	{
		private readonly DnDSolutionsDbContext db;
		private readonly IConfigurationProvider provider;

		public BoatService(DnDSolutionsDbContext db, IConfigurationProvider provider)
		{
			this.db = db;
			this.provider = provider;
		}

		public IEnumerable<BoatListingServiceModel> AllBoats(int page = 1)
			=> this.db
				.Boats
				.OrderByDescending(b => b.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<BoatListingServiceModel>(this.provider)
				.ToList();

		public int TotalBoats() => this.db.Boats.Count();

		public Boat CreateBoat(
			string deliveryTitle,
			BoatType type,
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
			bool isOnTrailer,
			string pickupLocation,
			string deliveryLocation,
			string description,
			DateTime collectionDateEarliest,
			DateTime collectionDateLatest,
			DateTime deliveryDateEarliest,
			DateTime deliveryDateLatest,
			IEnumerable<BoatServiceType> serviceTypes,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId)
		{
			Boat boat = new Boat
			{
				Title = deliveryTitle,
				Type = type,
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
				IsOnTrailer = isOnTrailer,
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				Description = description,
				CollectionDateEarliest = collectionDateEarliest,
				CollectionDateLatest = collectionDateLatest,
				DeliveryDateEarliest = deliveryDateEarliest,
				DeliveryDateLatest = deliveryDateLatest,
				ServiceType = (BoatServiceType)serviceTypes.Cast<int>().Sum(),
				AdditionalDetails = additionalDetails,
				CreateDate = createDate,
				UserId = userId,
			};

			this.db.Add(boat);

			this.db.SaveChanges();

			this.SavePhotos(boat.Id, photoPaths);

			return boat;
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

		public BoatDetailsServiceModel BoatDetails(int id)
			=> this.db
				.Boats
				.Where(b => b.Id == id)
				.ProjectTo<BoatDetailsServiceModel>(this.provider)
				.FirstOrDefault();
	}
}
