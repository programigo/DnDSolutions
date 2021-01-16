using DnDSolutions.Data;
using DnDSolutions.Data.Models.Freights;
using DnDSolutions.Services.Models.Freights;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Services
{
	public interface IFreightService
	{
		IEnumerable<LessThanContainerLoadListingServiceModel> AllLCLs(int page = 1);

		int TotalLCLs();

		LessThanContainerLoad CreateLessThanLoad(
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
			bool hasInsurance,
			string pickupLocation,
			string deliveryLocation,
			DateTime collectionDate,
			DateTime deliveryDate,
			IEnumerable<string> photoPaths,
			string additionalDetails,
			DateTime createDate,
			string userId);

		LessThanContainerLoadDetailsServiceModel LessThanContainerLoadDetails(int id);
	}
}
