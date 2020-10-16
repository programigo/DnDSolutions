namespace DnDSolutions.Services.Admin
{
	public interface IAdminDeliveryService
	{
		void RemoveCat(int id);

		void RemoveDog(int id);

		void RemoveHorse(int id);

		void RemoveLivestock(int id);

		void RemoveBoat(int id);

		void RemoveLessThanContainerLoad(int id);

		void RemoveArt(int id);

		void RemoveHouseholdItem(int id);

		void RemoveMoveItem(int id);

		void RemoveOffice(int id);

		void RemovePiano(int id);

		void RemoveATV(int id);

		void RemoveCar(int id);

		void RemoveHeavyVehicle(int id);

		void RemoveMotorcycle(int id);

		void RemoveRecreationalVehicle(int id);
	}
}
