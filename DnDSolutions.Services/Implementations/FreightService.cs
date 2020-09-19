using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Freights;
using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Services.Models.Freights;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
	public class FreightService : IFreightService
	{
		private readonly DnDSolutionsDbContext db;
		private readonly IConfigurationProvider provider;

		public FreightService(DnDSolutionsDbContext db, IConfigurationProvider provider)
		{
			this.db = db;
			this.provider = provider;
		}

		public IEnumerable<LessThanContainerLoadListingServiceModel> AllLCLs(int page = 1)
		=> this.db
			.LessThanContainerLoads
			.OrderByDescending(lcl => lcl.CreateDate)
			.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
			.Take(ServiceConstants.DeliveryListingPageSize)
			.ProjectTo<LessThanContainerLoadListingServiceModel>(this.provider)
			.ToList();

		public int TotalLCLs() => this.db.LessThanContainerLoads.Count();

		public LessThanContainerLoad CreateLessThanLoad(
			string deliveryTitle,
			LessThanContainerLoadType type,
			HandlingUnitType handlingUnit,
			MeasurementUnit measurementUnit,
			int lengthFirstPart,
			int? lengthSecondPart,
			int widthFirstPart,
			int? widthSecondPart,
			int heightFirstPart,
			int? heightSecondPart,
			int weight,
			int quantity,
			bool isStackable,
			bool isHazardous,
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
			LessThanContainerLoad lessThanLoad = new LessThanContainerLoad
			{
				Title = deliveryTitle,
				Type = type,
				HandlingUnit = handlingUnit,
				MeasurementUnit = measurementUnit,
				LengthFirstPart = lengthFirstPart,
				LengthSecondPart = lengthSecondPart,
				WidthFirstPart = widthFirstPart,
				WidthSecondPart = widthSecondPart,
				HeightFirstPart = heightFirstPart,
				HeightSecondPart = heightSecondPart,
				Weight = weight,
				Quantity = quantity,
				IsStackable = isStackable,
				IsHazardous = isHazardous,
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

			this.db.Add(lessThanLoad);

			this.db.SaveChanges();

			this.SavePhotos(lessThanLoad.Id, photoPaths);

			return lessThanLoad;
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

		public LessThanContainerLoadDetailsServiceModel LessThanContainerLoadDetails(int id)
			=> this.db
				.LessThanContainerLoads
				.Where(lcl => lcl.Id == id)
				.ProjectTo<LessThanContainerLoadDetailsServiceModel>(this.provider)
				.FirstOrDefault();
	}
}
