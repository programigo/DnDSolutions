using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Services.Models.HouseholdItemsAndMoves;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
	public class HouseholdItemsAndMovesService : IHouseholdItemsAndMovesService
	{
		private readonly DnDSolutionsDbContext db;
		private readonly IConfigurationProvider provider;

		public HouseholdItemsAndMovesService(DnDSolutionsDbContext db, IConfigurationProvider provider)
		{
			this.db = db;
			this.provider = provider;
		}

		public IEnumerable<ArtListingServiceModel> AllArts(int page = 1)
			=> this.db
				.Arts
				.OrderByDescending(a => a.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<ArtListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<HouseholdItemListingServiceModel> AllHouseholdItems(int page = 1)
			=> this.db
				.HouseholdItems
				.OrderByDescending(h => h.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<HouseholdItemListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<MoveListingServiceModel> AllMoves(int page = 1)
			=> this.db
				.Moves
				.OrderByDescending(m => m.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<MoveListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<OfficeListingServiceModel> AllOffices(int page = 1)
			=> this.db
				.Offices
				.OrderByDescending(o => o.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<OfficeListingServiceModel>(this.provider)
				.ToList();

		public IEnumerable<PianoListingServiceModel> AllPianos(int page = 1)
			=> this.db
				.Pianos
				.OrderByDescending(p => p.CreateDate)
				.Skip((page - 1) * ServiceConstants.DeliveryListingPageSize)
				.Take(ServiceConstants.DeliveryListingPageSize)
				.ProjectTo<PianoListingServiceModel>(this.provider)
				.ToList();

		public int TotalArts() => this.db.Arts.Count();

		public int TotalHouseholdItems() => this.db.HouseholdItems.Count();

		public int TotalMoves() => this.db.Moves.Count();

		public int TotalOffices() => this.db.Offices.Count();

		public int TotalPianos() => this.db.Pianos.Count();

		public Art CreateArt(
			ArtType type,
			string deliveryTitle,
			MeasurementUnit measurementUnit,
			int lengthFirstPart,
			int? lengthSecondPart,
			int widthFirstPart,
			int? widthSecondPart,
			int heightFirstPart,
			int? heightSecondPart,
			int weight,
			string description,
			string packaging,
			string specialHandling,
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
			Art art = new Art
			{
				Type = type,
				Title = deliveryTitle,
				MeasurementUnit = measurementUnit,
				LengthSecondPart = lengthSecondPart,
				WidthFirstPart = widthFirstPart,
				WidthSecondPart = widthSecondPart,
				HeightFirstPart = heightFirstPart,
				HeightSecondPart = heightSecondPart,
				Weight = weight,
				Description = description,
				Packaging = packaging,
				SpecialHandling = specialHandling,
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

			this.db.Add(art);

			this.db.SaveChanges();

			this.SavePhotos(art.Id, photoPaths);

			return art;
		}

		public HouseholdItem CreateHouseholdItem(
			int numberOfItems,
			HouseholdItemType type,
			string deliveryTitle,
			MeasurementUnit measurementUnit,
			int lengthFirstPart,
			int? lengthSecondPart,
			int widthFirstPart,
			int? widthSecondPart,
			int heightFirstPart,
			int? heightSecondPart,
			int weight,
			bool isPalletised,
			bool isCrated,
			bool isStickable,
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
			HouseholdItem household = new HouseholdItem
			{
				NumberOfItems = numberOfItems,
				Type = type,
				Title = deliveryTitle,
				MeasurementUnit = measurementUnit,
				LengthFirstPart = lengthFirstPart,
				LengthSecondPart = lengthSecondPart,
				WidthFirstPart = widthFirstPart,
				WidthSecondPart = widthSecondPart,
				HeightFirstPart = heightFirstPart,
				HeightSecondPart = heightSecondPart,
				Weight = weight,
				IsPalletised = isPalletised,
				IsCrated = isCrated,
				IsStickable = isStickable,
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

			this.db.Add(household);

			this.db.SaveChanges();

			this.SavePhotos(household.Id, photoPaths);

			return household;
		}

		public Move CreateMove(
			MoveType type,
			string deliveryTitle,
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
			Move move = new Move
			{
				Type = type,
				Title = deliveryTitle,
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

			this.db.Add(move);

			this.db.SaveChanges();

			this.SavePhotos(move.Id, photoPaths);

			return move;
		}

		public Office CreateOffice(
			int collectionFloor,
			bool hasCollectionFloorElevator,
			int deliveryFloor,
			bool hasDeliveryFloorElevator,
			bool hasDisassemblyItems,
			bool hasReassemblyItems,
			string deliveryTitle,
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
			Office office = new Office
			{
				CollectionFloor = collectionFloor,
				HasCollectionFloorElevator = hasCollectionFloorElevator,
				DeliveryFloor = deliveryFloor,
				HasDeliveryFloorElevator = hasDeliveryFloorElevator,
				HasDisassemblyItems = hasDisassemblyItems,
				HasReassemblyItems = hasReassemblyItems,
				Title = deliveryTitle,
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

			this.db.Add(office);

			this.db.SaveChanges();

			this.SavePhotos(office.Id, photoPaths);

			return office;
		}

		public Piano CreatePiano(
			string deliveryTitle,
			PianoType type,
			VerticalPianoType verticalType,
			HorizontalPianoType horizontalType,
			bool? isOnCasters,
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
			Piano piano = new Piano
			{
				Title = deliveryTitle,
				Type = type,
				VerticalType = verticalType,
				HorizontalType = horizontalType,
				IsOnCasters = isOnCasters,
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

			this.db.Add(piano);

			this.db.SaveChanges();

			this.SavePhotos(piano.Id, photoPaths);

			return piano;
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

		public ArtDetailsServiceModel ArtDetails(int id)
			=> this.db
				.Arts
				.Where(a => a.Id == id)
				.ProjectTo<ArtDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public HouseholdItemDetailsServiceModel HouseholdItemDetails(int id)
			=> this.db
				.HouseholdItems
				.Where(h => h.Id == id)
				.ProjectTo<HouseholdItemDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public MoveDetailsServiceModel MoveDetails(int id)
			=> this.db
				.Moves
				.Where(m => m.Id == id)
				.ProjectTo<MoveDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public OfficeDetailsServiceModel OfficeDetails(int id)
			=> this.db
				.Offices
				.Where(o => o.Id == id)
				.ProjectTo<OfficeDetailsServiceModel>(this.provider)
				.FirstOrDefault();

		public PianoDetailsServiceModel PianoDetails(int id)
			=> this.db
				.Pianos
				.Where(p => p.Id == id)
				.ProjectTo<PianoDetailsServiceModel>(this.provider)
				.FirstOrDefault();
	}
}
