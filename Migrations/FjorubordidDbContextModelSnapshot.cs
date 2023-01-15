﻿// <auto-generated />
using System;
using Fjorubordid_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace fjorubordidapi.Migrations
{
    [DbContext(typeof(FjorubordidDbContext))]
    partial class FjorubordidDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fjorubordid_Api.Models.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrinkId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("DrinkId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            DrinkId = 1,
                            Description = "Egils Gull 0.5l",
                            ImagePath = "gull.png",
                            Name = "Egils Gull 0.5l",
                            Quantity = 1,
                            UnitPrice = 1400
                        },
                        new
                        {
                            DrinkId = 2,
                            Description = "Egils Gull 0.3l",
                            ImagePath = "gull.png",
                            Name = "Egils Gull 0.3l",
                            Quantity = 1,
                            UnitPrice = 1200
                        },
                        new
                        {
                            DrinkId = 3,
                            Description = "Flaska af hvítvíni hússins",
                            ImagePath = "white.jpg",
                            Name = "Hvítvín hússins",
                            Quantity = 1,
                            UnitPrice = 7200
                        },
                        new
                        {
                            DrinkId = 4,
                            Description = "Flaska af rauðvíni hússins",
                            ImagePath = "red.png",
                            Name = "Rauðvín hússins",
                            Quantity = 1,
                            UnitPrice = 7200
                        },
                        new
                        {
                            DrinkId = 5,
                            Description = "Pepsi í gleri 330ml",
                            ImagePath = "pepsi.jpg",
                            Name = "Pepsi",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 6,
                            Description = "Pepsi í gleri 330ml",
                            ImagePath = "pepsimax.jpg",
                            Name = "Pepsi Max",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 7,
                            Description = "7up í gleri 330ml",
                            ImagePath = "7up.jpg",
                            Name = "7up",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 8,
                            Description = "Appelsín í gleri 330ml",
                            ImagePath = "appelsin.png",
                            Name = "Appelsín",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 9,
                            Description = "Kristall í gleri 330ml án bragðefna",
                            ImagePath = "kristall.jpg",
                            Name = "Kristall",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 10,
                            Description = "Sleipnir Pale Ale frá Ölvisholt Brugghús 330ml",
                            ImagePath = "sleipnir.jpg",
                            Name = "Sleipnir Pale Ale",
                            Quantity = 1,
                            UnitPrice = 1600
                        });
                });

            modelBuilder.Entity("Fjorubordid_Api.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("FoodId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Description = "3ja rétta 400g",
                            ImagePath = "humar.jpg",
                            Name = "3ja rétta 400g",
                            Quantity = 1,
                            UnitPrice = 14175
                        },
                        new
                        {
                            FoodId = 2,
                            Description = "3ja rétta 300g",
                            ImagePath = "humar.jpg",
                            Name = "3ja rétta 300g",
                            Quantity = 1,
                            UnitPrice = 12250
                        },
                        new
                        {
                            FoodId = 3,
                            Description = "Leturhumar 400g",
                            ImagePath = "humar.jpg",
                            Name = "Humar 400g",
                            Quantity = 1,
                            UnitPrice = 10750
                        },
                        new
                        {
                            FoodId = 4,
                            Description = "Leturhumar 300g",
                            ImagePath = "humar.jpg",
                            Name = "Humar 300g",
                            Quantity = 1,
                            UnitPrice = 8650
                        },
                        new
                        {
                            FoodId = 5,
                            Description = "Leturhumar 250g",
                            ImagePath = "humar.jpg",
                            Name = "Humar 250g",
                            Quantity = 1,
                            UnitPrice = 8050
                        },
                        new
                        {
                            FoodId = 6,
                            Description = "Aðalréttur",
                            ImagePath = "supa.jpg",
                            Name = "Humarsúpa",
                            Quantity = 1,
                            UnitPrice = 4190
                        },
                        new
                        {
                            FoodId = 7,
                            Description = "Forréttur",
                            ImagePath = "supa.jpg",
                            Name = "Humarsúpa",
                            Quantity = 1,
                            UnitPrice = 3250
                        },
                        new
                        {
                            FoodId = 8,
                            Description = "Grænmetisréttur",
                            ImagePath = "green.jpg",
                            Name = "Grænmetisréttur",
                            Quantity = 1,
                            UnitPrice = 4190
                        },
                        new
                        {
                            FoodId = 9,
                            Description = "Lambahryggvöðvi",
                            ImagePath = "lamb.jpg",
                            Name = "Lambahryggvöðvi",
                            Quantity = 1,
                            UnitPrice = 6250
                        },
                        new
                        {
                            FoodId = 10,
                            Description = "Barnamatseðill",
                            ImagePath = "naggar.jpg",
                            Name = "Kjúklinganaggar",
                            Quantity = 1,
                            UnitPrice = 990
                        },
                        new
                        {
                            FoodId = 11,
                            Description = "Barnamatseðill",
                            ImagePath = "samloka.jpg",
                            Name = "Samloka",
                            Quantity = 1,
                            UnitPrice = 990
                        },
                        new
                        {
                            FoodId = 12,
                            Description = "Eftirréttur tertusneið",
                            ImagePath = "dessert.jpg",
                            Name = "Eftirréttur",
                            Quantity = 1,
                            UnitPrice = 1650
                        });
                });

            modelBuilder.Entity("Fjorubordid_Api.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrinkId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Fjorubordid_Api.Models.Drink", b =>
                {
                    b.HasOne("Fjorubordid_Api.Models.OrderItem", null)
                        .WithMany("Drink")
                        .HasForeignKey("OrderItemId");
                });

            modelBuilder.Entity("Fjorubordid_Api.Models.Food", b =>
                {
                    b.HasOne("Fjorubordid_Api.Models.OrderItem", "OrderItem")
                        .WithMany("Food")
                        .HasForeignKey("OrderItemId");

                    b.Navigation("OrderItem");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fjorubordid_Api.Models.OrderItem", b =>
                {
                    b.Navigation("Drink");

                    b.Navigation("Food");
                });
#pragma warning restore 612, 618
        }
    }
}
