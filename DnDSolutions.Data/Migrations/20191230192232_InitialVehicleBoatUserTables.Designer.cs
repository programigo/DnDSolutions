﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DnDSolutions.Data.Migrations
{
    [DbContext(typeof(DnDSolutionsDbContext))]
    [Migration("20191230192232_InitialVehicleBoatUserTables")]
    partial class InitialVehicleBoatUserTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DnDSolutions.Data.DeliveryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CollectionDateEarliest")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CollectionDateLatest")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDateEarliest")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDateLatest")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeliveryItem");

                    b.HasDiscriminator<string>("Discriminator").HasValue("DeliveryItem");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Photos.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryItemId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryItemId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Boat", b =>
                {
                    b.HasBaseType("DnDSolutions.Data.DeliveryItem");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsOnTrailer")
                        .HasColumnType("bit");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("Boat");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Car", b =>
                {
                    b.HasBaseType("DnDSolutions.Data.DeliveryItem");

                    b.Property<int>("BodyType")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnName("Car_Make")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("Car_Model")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnName("Car_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("Car");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Motorcycle", b =>
                {
                    b.HasBaseType("DnDSolutions.Data.DeliveryItem");

                    b.Property<string>("DeliveryLocation")
                        .IsRequired()
                        .HasColumnName("Motorcycle_DeliveryLocation")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnName("Motorcycle_Make")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("Motorcycle_Model")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasColumnName("Motorcycle_PickupLocation")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("State")
                        .HasColumnName("Motorcycle_State")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnName("Motorcycle_Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnName("Motorcycle_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("Motorcycle");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.RecreationalVehicle", b =>
                {
                    b.HasBaseType("DnDSolutions.Data.DeliveryItem");

                    b.Property<bool?>("CanBeDriven")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnName("RecreationalVehicle_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnName("RecreationalVehicle_Height")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<double>("Length")
                        .HasColumnName("RecreationalVehicle_Length")
                        .HasColumnType("float");

                    b.Property<string>("Make")
                        .HasColumnName("RecreationalVehicle_Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnName("RecreationalVehicle_Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnName("RecreationalVehicle_Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnName("RecreationalVehicle_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Weight")
                        .HasColumnName("RecreationalVehicle_Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnName("RecreationalVehicle_Width")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("RecreationalVehicle");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Snowmobile", b =>
                {
                    b.HasBaseType("DnDSolutions.Data.DeliveryItem");

                    b.Property<double>("Height")
                        .HasColumnName("Snowmobile_Height")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnName("Snowmobile_Length")
                        .HasColumnType("float");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnName("Snowmobile_Make")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("Snowmobile_Model")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UserId")
                        .HasColumnName("Snowmobile_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Weight")
                        .HasColumnName("Snowmobile_Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnName("Snowmobile_Width")
                        .HasColumnType("float");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("Snowmobile");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Photos.Photo", b =>
                {
                    b.HasOne("DnDSolutions.Data.DeliveryItem", "DeliveryItem")
                        .WithMany("Photos")
                        .HasForeignKey("DeliveryItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnDSolutions.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Boat", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", "User")
                        .WithMany("Boats")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Car", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Motorcycle", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", "User")
                        .WithMany("Motorcycles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.RecreationalVehicle", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", "User")
                        .WithMany("RecreationalVehicles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DnDSolutions.Data.Models.Snowmobile", b =>
                {
                    b.HasOne("DnDSolutions.Data.Models.User", "User")
                        .WithMany("Snowmobiles")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
