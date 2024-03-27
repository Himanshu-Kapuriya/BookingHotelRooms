﻿// <auto-generated />
using System;
using BookingHotelRooms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingHotelRooms.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231026211233_SeedingBookings")]
    partial class SeedingBookings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingHotelRooms.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "df62e5e9-1a75-4f3c-87c0-6ab4fb5e449d",
                            Email = "mada@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MADA@YAHOO.COM",
                            NormalizedUserName = "MADA",
                            PasswordHash = "AQAAAAEAACcQAAAAEJj2oEEflG3W/wMvcwufShiiEBcX+8l0DeEZ6yJ3y6EL4Alk5zMTb4FlTozl8QA9fg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "525a5b38-94f3-41a8-b34e-28a3a3fe4f27",
                            TwoFactorEnabled = false,
                            UserName = "mada"
                        },
                        new
                        {
                            Id = "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2898abc8-ef3b-4ec3-95bc-dcada25703cb",
                            Email = "andrei@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANDREI@YAHOO.COM",
                            NormalizedUserName = "ANDREI",
                            PasswordHash = "AQAAAAEAACcQAAAAEJcRbStj0EBk5Kp97KHwsbqpiBlVgFYaojKBI/CoxVzGlfgulywu2vatx1rVI9qHHg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "30e6b3cf-6b48-41bf-b587-271ba18cf2e3",
                            TwoFactorEnabled = false,
                            UserName = "Andrei"
                        });
                });

            modelBuilder.Entity("BookingHotelRooms.Models.Booking", b =>
                {
                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookingStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BookingId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingId = "9GADGDSHS1256",
                            AppUserId = "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                            BookingStatus = "Completed",
                            CheckIn = new DateTime(2023, 10, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2023, 10, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDate = new DateTime(2023, 10, 27, 0, 12, 33, 38, DateTimeKind.Local).AddTicks(5183),
                            RoomId = 1,
                            TotalPrice = 17.99m
                        },
                        new
                        {
                            BookingId = "GTG5WR8T23",
                            AppUserId = "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                            BookingStatus = "Completed",
                            CheckIn = new DateTime(2023, 10, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2023, 10, 31, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDate = new DateTime(2023, 10, 27, 0, 12, 33, 42, DateTimeKind.Local).AddTicks(5266),
                            RoomId = 2,
                            TotalPrice = 45.98m
                        },
                        new
                        {
                            BookingId = "GADGDHGS1251",
                            AppUserId = "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                            BookingStatus = "Completed",
                            CheckIn = new DateTime(2023, 10, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2023, 10, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDate = new DateTime(2023, 10, 27, 0, 12, 33, 42, DateTimeKind.Local).AddTicks(5300),
                            RoomId = 5,
                            TotalPrice = 80.99m
                        },
                        new
                        {
                            BookingId = "GHDHREU4746",
                            AppUserId = "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                            BookingStatus = "Completed",
                            CheckIn = new DateTime(2023, 10, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDate = new DateTime(2023, 10, 27, 0, 12, 33, 42, DateTimeKind.Local).AddTicks(5305),
                            RoomId = 1,
                            TotalPrice = 17.99m
                        },
                        new
                        {
                            BookingId = "43635MGGJIRAO",
                            AppUserId = "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                            BookingStatus = "Completed",
                            CheckIn = new DateTime(2023, 10, 25, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2023, 10, 26, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDate = new DateTime(2023, 10, 27, 0, 12, 33, 42, DateTimeKind.Local).AddTicks(5309),
                            RoomId = 5,
                            TotalPrice = 80.99m
                        });
                });

            modelBuilder.Entity("BookingHotelRooms.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Description = "First Room Description",
                            IsAvailable = false,
                            Price = 17.99m,
                            RoomNumber = 1
                        },
                        new
                        {
                            RoomId = 2,
                            Description = "Second Room Description",
                            IsAvailable = true,
                            Price = 22.99m,
                            RoomNumber = 2
                        },
                        new
                        {
                            RoomId = 3,
                            Description = "100th Room Description",
                            IsAvailable = false,
                            Price = 29.99m,
                            RoomNumber = 100
                        },
                        new
                        {
                            RoomId = 4,
                            Description = "22th Room Description",
                            IsAvailable = true,
                            Price = 100.99m,
                            RoomNumber = 22
                        },
                        new
                        {
                            RoomId = 5,
                            Description = "Fifth Room Description",
                            IsAvailable = true,
                            Price = 80.99m,
                            RoomNumber = 5
                        });
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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            ConcurrencyStamp = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            ConcurrencyStamp = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            Name = "User",
                            NormalizedName = "USER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                            RoleId = "02174cf0–9412–4cfe-afbf-59f706d72cf6"
                        },
                        new
                        {
                            UserId = "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                            RoleId = "341743f0-asd2–42de-afbf-59kmkkmk72cf6"
                        });
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

            modelBuilder.Entity("BookingHotelRooms.Models.Booking", b =>
                {
                    b.HasOne("BookingHotelRooms.Models.AppUser", "ApplicationUser")
                        .WithMany("Bookings")
                        .HasForeignKey("AppUserId");

                    b.HasOne("BookingHotelRooms.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Room");
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
                    b.HasOne("BookingHotelRooms.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookingHotelRooms.Models.AppUser", null)
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

                    b.HasOne("BookingHotelRooms.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookingHotelRooms.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookingHotelRooms.Models.AppUser", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
