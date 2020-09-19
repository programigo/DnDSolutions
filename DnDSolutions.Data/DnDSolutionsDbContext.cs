using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Animals;
using DnDSolutions.Data.Models.Chat;
using DnDSolutions.Data.Models.Freights;
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;
using DnDSolutions.Data.Models.Photos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DnDSolutions.Data
{
	public class DnDSolutionsDbContext : IdentityDbContext<User>
	{
		public DnDSolutionsDbContext(DbContextOptions<DnDSolutionsDbContext> options)
			: base(options)
		{
		}

		public DbSet<Car> Cars { get; set; }

		public DbSet<Motorcycle> Motorcycles { get; set; }

		public DbSet<Boat> Boats { get; set; }

		public DbSet<RecreationalVehicle> RecreationalVehicles { get; set; }

		public DbSet<Snowmobile> Snowmobiles { get; set; }

		public DbSet<ATV> ATVs { get; set; }

		public DbSet<HeavyVehicle> HeavyVehicles { get; set; }

		public DbSet<Piano> Pianos { get; set; }

		public DbSet<HouseholdItem> HouseholdItems { get; set; }

		public DbSet<Photo> Photos { get; set; }

		public DbSet<Art> Arts { get; set; }

		public DbSet<Move> Moves { get; set; }

		public DbSet<Office> Offices { get; set; }

		public DbSet<Cat> Cats { get; set; }

		public DbSet<Dog> Dogs { get; set; }

		public DbSet<Horse> Horses { get; set; }

		public DbSet<Livestock> Livestock { get; set; }

		public DbSet<LessThanContainerLoad> LessThanContainerLoads { get; set; }

		public DbSet<Bid> Bids { get; set; }

		public DbSet<Message> Messages { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder
				.Entity<Message>()
				.HasOne(m => m.User)
				.WithMany(u => u.Messages)
				.HasForeignKey(m => m.UserId);

			builder
				.Entity<Bid>()
				.HasOne(b => b.DeliveryItem)
				.WithMany(di => di.Bids)
				.HasForeignKey(b => b.DeliveryItemId);

			builder
				.Entity<Bid>()
				.HasOne(b => b.User)
				.WithMany(u => u.Bids)
				.HasForeignKey(b => b.UserId);

			builder
			   .Entity<LessThanContainerLoad>()
			   .HasOne(lcl => lcl.User)
			   .WithMany(u => u.LessThanContainerLoads)
			   .HasForeignKey(lcl => lcl.UserId);

			builder
			   .Entity<Livestock>()
			   .HasOne(ls => ls.User)
			   .WithMany(u => u.Livestock)
			   .HasForeignKey(ls => ls.UserId);

			builder
			   .Entity<Horse>()
			   .HasOne(h => h.User)
			   .WithMany(u => u.Horses)
			   .HasForeignKey(h => h.UserId);

			builder
			   .Entity<Dog>()
			   .HasOne(d => d.User)
			   .WithMany(u => u.Dogs)
			   .HasForeignKey(d => d.UserId);

			builder
			   .Entity<Cat>()
			   .HasOne(c => c.User)
			   .WithMany(u => u.Cats)
			   .HasForeignKey(c => c.UserId);

			builder
			   .Entity<Office>()
			   .HasOne(o => o.User)
			   .WithMany(u => u.Offices)
			   .HasForeignKey(o => o.UserId);

			builder
			   .Entity<Move>()
			   .HasOne(m => m.User)
			   .WithMany(u => u.Moves)
			   .HasForeignKey(m => m.UserId);

			builder
			   .Entity<Art>()
			   .HasOne(a => a.User)
			   .WithMany(u => u.Arts)
			   .HasForeignKey(a => a.UserId);

			builder
			   .Entity<Piano>()
			   .HasOne(p => p.User)
			   .WithMany(u => u.Pianos)
			   .HasForeignKey(p => p.UserId);

			builder
			   .Entity<HouseholdItem>()
			   .HasOne(f => f.User)
			   .WithMany(u => u.HouseholdItems)
			   .HasForeignKey(f => f.UserId);

			builder
			   .Entity<HeavyVehicle>()
			   .HasOne(hv => hv.User)
			   .WithMany(u => u.HeavyVehicles)
			   .HasForeignKey(hv => hv.UserId);

			builder
				.Entity<ATV>()
				.HasOne(atv => atv.User)
				.WithMany(u => u.ATVs)
				.HasForeignKey(atv => atv.UserId);

			builder
				.Entity<Boat>()
				.HasOne(b => b.User)
				.WithMany(u => u.Boats)
				.HasForeignKey(b => b.UserId);

			builder
				.Entity<Car>()
				.HasOne(c => c.User)
				.WithMany(u => u.Cars)
				.HasForeignKey(c => c.UserId);

			builder
				.Entity<Motorcycle>()
				.HasOne(m => m.User)
				.WithMany(u => u.Motorcycles)
				.HasForeignKey(m => m.UserId);

			builder
				.Entity<RecreationalVehicle>()
				.HasOne(rv => rv.User)
				.WithMany(u => u.RecreationalVehicles)
				.HasForeignKey(rv => rv.UserId);

			builder
				.Entity<Snowmobile>()
				.HasOne(sm => sm.User)
				.WithMany(u => u.Snowmobiles)
				.HasForeignKey(sm => sm.UserId);

			builder
				.Entity<Photo>()
				.HasOne(p => p.DeliveryItem)
				.WithMany(di => di.Photos)
				.HasForeignKey(p => p.DeliveryItemId);

			base.OnModelCreating(builder);
		}
	}
}
