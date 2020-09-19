using AutoMapper;
using DnDSolutions.Data;
using DnDSolutions.Data.Models;
using DnDSolutions.Services;
using DnDSolutions.Web.Infrastructure.Extensions;
using DnDSolutions.Web.SignalRChat.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DnDSolutions.Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DnDSolutionsDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));

			services.Configure<AuthMessageSenderOptions>(Configuration);

			services.AddIdentity<User, IdentityRole>(options =>
			{
				options.User.RequireUniqueEmail = true;
				options.Password.RequireDigit = false;
				options.Password.RequireLowercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
			})
				.AddEntityFrameworkStores<DnDSolutionsDbContext>()
				.AddDefaultTokenProviders();

			services.AddAutoMapper(typeof(Startup));

			services.AddDomainServices();

			services.AddControllersWithViews();

			services.AddRazorPages();

			services.AddSignalR();

			services.AddMvc(options =>
			{
				options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseDatabaseMigration();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapAreaControllerRoute(
					name: "admin",
					areaName: "admin",
					pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapAreaControllerRoute(
					name: "animals",
					areaName: "animals",
					pattern: "Animals/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapAreaControllerRoute(
					name: "vehicles",
					areaName: "vehicles",
					pattern: "Vehicles/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapAreaControllerRoute(
					name: "householdItemsAndMoves",
					areaName: "householdItemsAndMoves",
					pattern: "HouseholdItemsAndMoves/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapAreaControllerRoute(
					name: "freights",
					areaName: "freights",
					pattern: "Freights/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

				endpoints.MapRazorPages();

				endpoints.MapHub<ChatHub>("/Messages/Index");
			});
		}
	}
}
