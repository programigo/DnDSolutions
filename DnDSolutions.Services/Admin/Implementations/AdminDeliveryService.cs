using DnDSolutions.Data;
using System;

namespace DnDSolutions.Services.Admin.Implementations
{
	public class AdminDeliveryService : IAdminDeliveryService
	{
		private readonly DnDSolutionsDbContext db;

		public AdminDeliveryService(DnDSolutionsDbContext db)
		{
			this.db = db;
		}

		public void RemoveArt(int id)
		{
			throw new NotImplementedException();
		}

		public void RemoveATV(int id)
		{
			var atv = this.db.ATVs.Find(id);

			if (atv == null)
			{
				return;
			}

			this.db.Remove(atv);

			this.db.SaveChanges();
		}

		public void RemoveBoat(int id)
		{
			var boat = this.db.Boats.Find(id);

			if (boat == null)
			{
				return;
			}

			this.db.Remove(boat);

			this.db.SaveChanges();
		}

		public void RemoveCar(int id)
		{
			var car = this.db.Cars.Find(id);

			if (car == null)
			{
				return;
			}

			this.db.Remove(car);

			this.db.SaveChanges();
		}

		public void RemoveCat(int id)
		{
			var cat = this.db.Cats.Find(id);

			if (cat == null)
			{
				return;
			}

			this.db.Remove(cat);

			this.db.SaveChanges();
		}

		public void RemoveDog(int id)
		{
			var dog = this.db.Dogs.Find(id);

			if (dog == null)
			{
				return;
			}

			this.db.Remove(dog);

			this.db.SaveChanges();
		}

		public void RemoveHeavyVehicle(int id)
		{
			var hv = this.db.HeavyVehicles.Find(id);

			if (hv == null)
			{
				return;
			}

			this.db.Remove(hv);

			this.db.SaveChanges();
		}

		public void RemoveHorse(int id)
		{
			var horse = this.db.Horses.Find(id);

			if (horse == null)
			{
				return;
			}

			this.db.Remove(horse);

			this.db.SaveChanges();
		}

		public void RemoveHouseholdItem(int id)
		{
			var householdItem = this.db.HouseholdItems.Find(id);

			if (householdItem == null)
			{
				return;
			}

			this.db.Remove(householdItem);

			this.db.SaveChanges();
		}

		public void RemoveLessThanContainerLoad(int id)
		{
			var lcl = this.db.LessThanContainerLoads.Find(id);

			if (lcl == null)
			{
				return;
			}

			this.db.Remove(lcl);

			this.db.SaveChanges();
		}

		public void RemoveLivestock(int id)
		{
			var livestock = this.db.Livestock.Find(id);

			if (livestock == null)
			{
				return;
			}

			this.db.Remove(livestock);

			this.db.SaveChanges();
		}

		public void RemoveMotorcycle(int id)
		{
			var motorcycle = this.db.Motorcycles.Find(id);

			if (motorcycle == null)
			{
				return;
			}

			this.db.Remove(motorcycle);

			this.db.SaveChanges();
		}

		public void RemoveMoveItem(int id)
		{
			var move = this.db.Moves.Find(id);

			if (move == null)
			{
				return;
			}

			this.db.Remove(move);

			this.db.SaveChanges();
		}

		public void RemoveOffice(int id)
		{
			var office = this.db.Offices.Find(id);

			if (office == null)
			{
				return;
			}

			this.db.Remove(office);

			this.db.SaveChanges();
		}

		public void RemovePiano(int id)
		{
			var piano = this.db.Pianos.Find(id);

			if (piano == null)
			{
				return;
			}

			this.db.Remove(piano);

			this.db.SaveChanges();
		}

		public void RemoveRecreationalVehicle(int id)
		{
			var recreationalVehicle = this.db.RecreationalVehicles.Find(id);

			if (recreationalVehicle == null)
			{
				return;
			}

			this.db.Remove(recreationalVehicle);

			this.db.SaveChanges();
		}
	}
}
