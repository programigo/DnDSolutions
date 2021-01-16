using DnDSolutions.Data.Models.Animals;
using DnDSolutions.Services.Models.Animals;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Services
{
    public interface IAnimalService
    {
        IEnumerable<CatListingServiceModel> AllCats(int page = 1);

        IEnumerable<DogListingServiceModel> AllDogs(int page = 1);

        IEnumerable<HorseListingServiceModel> AllHorses(int page = 1);

        IEnumerable<LivestockListingServiceModel> AllLivestock(int page = 1);

        int TotalCats();

        int TotalDogs();

        int TotalHorses();

        int TotalLivestock();

        Cat CreateCat(
            int count,
            string deliveryTitle,
            string name,
            string breed,
            int weight,
            bool hasAllVaccinations,
            bool hasCarrier,
            bool HasSpecificNeeds,
            bool hasInsurance,
            string pickupLocation,
            string deliveryLocation,
            DateTime collectionDate,
            DateTime deliveryDate,
            IEnumerable<string> photoPaths,
            string additionalDetails,
            DateTime createDate,
            string userId);

        Dog CreateDog(
            int count,
            string deliveryTitle,
            string name,
            string breed,
            int weight,
            bool hasAllVaccinations,
            bool hasCarrier,
            bool HasSpecificNeeds,
            bool hasInsurance,
            string pickupLocation,
            string deliveryLocation,
            DateTime collectionDate,
            DateTime deliveryDate,
            IEnumerable<string> photoPaths,
            string additionalDetails,
            DateTime createDate,
            string userId);

        Horse CreateHorse(
            int count,
            string deliveryTitle,
            HorseBreed breed,
            int weight,
            int height,
            string name,
            string pickupLocation,
            string deliveryLocation,
            bool hasInsurance,
            DateTime collectionDate,
            DateTime deliveryDate,
            IEnumerable<string> photoPaths,
            string additionalDetails,
            DateTime createDate,
            string userId);

        Livestock CreateLivestock(
            string deliveryTitle,
            string breed,
            int totalWeight,
            int count,
            bool hasAllVaccinations,
            bool hasAllTags,
            bool hasSpecificNeeds,
            bool hasInsurance,
            bool isInCorral,
            string pickupLocation,
            string deliveryLocation,
            DateTime collectionDate,
            DateTime deliveryDate,
            IEnumerable<string> photoPaths,
            string additionalDetails,
            DateTime createDate,
            string userId);

        CatDetailsServiceModel CatDetails(int id);

        DogDetailsServiceModel DogDetails(int id);

        HorseDetailsServiceModel HorseDetails(int id);

        LivestockDetailsServiceModel LivestockDetails(int id);
    }
}
