using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Services.Models.Vehicles;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Services
{
    public interface IVehicleService
    {
        IEnumerable<ATVListingServiceModel> AllATVs(int page = 1);

        IEnumerable<CarListingServiceModel> AllCars(int page = 1);

        IEnumerable<HeavyVehicleListingServiceModel> AllHeavyVehicles(int page = 1);

        IEnumerable<MotorcycleListingServiceModel> AllMotorcycles(int page = 1);

        IEnumerable<RecreationalVehicleListingServiceModel> AllRecreationalVehicles(int page = 1);

        int TotalATVs();

        int TotalCars();

        int TotalHeavyVehicles();

        int TotalMotorcycles();

        int TotalRecreationalVehicles();

        Car CreateCar(
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
            string userId);

        HeavyVehicle CreateHeavyVehicle(
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
            string userId);

        Motorcycle CreateMotorcycle(
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
            string userId);

        RecreationalVehicle CreateRecreationalVehicle(
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
            string userId);

        ATV CreateATV(
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
            string userId);

        ATVDetailsServiceModel ATVDetails(int id);

        CarDetailsServiceModel CarDetails(int id);

        HeavyVehicleDetailsServiceModel HeavyVehicleDetails(int id);

        MotorcycleDetailsServiceModel MotorcycleDetails(int id);

        RecreationalVehicleDetailsServiceModel RecreationalVehicleDetails(int id);
    }
}
