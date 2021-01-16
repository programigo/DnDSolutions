using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Services.Models.Boats;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Services
{
	public interface IBoatService
	{
		IEnumerable<BoatListingServiceModel> AllBoats(int page = 1);

		int TotalBoats();

		Boat CreateBoat(
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
			bool hasInsurance,
			string pickupLocation,
			string deliveryLocation,
			string description,
			DateTime collectionDate,
			DateTime deliveryDate,
			IEnumerable<BoatServiceType> serviceTypes,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId);

		BoatDetailsServiceModel BoatDetails(int id);
	}
}
