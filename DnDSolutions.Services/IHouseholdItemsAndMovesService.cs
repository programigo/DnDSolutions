using DnDSolutions.Data;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using DnDSolutions.Services.Models.HouseholdItemsAndMoves;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Services
{
	public interface IHouseholdItemsAndMovesService
	{
		IEnumerable<ArtListingServiceModel> AllArts(int page = 1);

		IEnumerable<HouseholdItemListingServiceModel> AllHouseholdItems(int page = 1);

		IEnumerable<MoveListingServiceModel> AllMoves(int page = 1);

		IEnumerable<OfficeListingServiceModel> AllOffices(int page = 1);

		IEnumerable<PianoListingServiceModel> AllPianos(int page = 1);

		int TotalArts();

		int TotalHouseholdItems();

		int TotalMoves();

		int TotalOffices();

		int TotalPianos();

		Art CreateArt(
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
			string userId);

		HouseholdItem CreateHouseholdItem(
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
			string userId);

		Move CreateMove(
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
			string userId);

		Office CreateOffice(
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
			string userId);

		Piano CreatePiano(
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
			string userId);

		ArtDetailsServiceModel ArtDetails(int id);

		HouseholdItemDetailsServiceModel HouseholdItemDetails(int id);

		MoveDetailsServiceModel MoveDetails(int id);

		OfficeDetailsServiceModel OfficeDetails(int id);

		PianoDetailsServiceModel PianoDetails(int id);
	}
}
