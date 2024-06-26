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
    [Migration("20240327140807_AddBlogCreatedTimestamp")]
    partial class AddBlogCreatedTimestamp
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
                            ConcurrencyStamp = "fdca24e7-64bf-40f9-b144-c65f7239d2c5",
                            Email = "mada@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MADA@YAHOO.COM",
                            NormalizedUserName = "MADA",
                            PasswordHash = "AQAAAAEAACcQAAAAEDRqg7J9EB0/8f+/mrDJrLDc+wStb3YJOusnVjsuCH7Or0ZjoF2m7w6jHYEgvE+dKA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "15a73be1-f411-447f-90fc-d6739a33fea8",
                            TwoFactorEnabled = false,
                            UserName = "mada"
                        },
                        new
                        {
                            Id = "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4adf07c2-69b7-4e55-ab5f-2a1e40607a7c",
                            Email = "andrei@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANDREI@YAHOO.COM",
                            NormalizedUserName = "ANDREI",
                            PasswordHash = "AQAAAAEAACcQAAAAEIXbUqR4cZ+Hgn/z7iRWqdHtLY6CU3JAoQIax+m5fzfMPOCo8lzxuiR8nS7tsuYlbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a338e100-eb63-4d86-a935-4c5a681e6772",
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
                            OrderDate = new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(2274),
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
                            OrderDate = new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8708),
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
                            OrderDate = new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8721),
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
                            OrderDate = new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8723),
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
                            OrderDate = new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8726),
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
                            Description = "Our Deln/Large Double also provides views over landscaped gardens. It has a seating area, digital safe and mini fridge. This room can be configured with either 2 single beds or zip and linked to provide a large double bed.",
                            Price = 17.99m,
                            RoomNumber = 1
                        },
                        new
                        {
                            RoomId = 2,
                            Description = "As our smallest budget rooms, the Compact bedrooms are suited for single occupancy or short-stay double occupancy as they have limited space and storage.",
                            Price = 22.99m,
                            RoomNumber = 2
                        },
                        new
                        {
                            RoomId = 3,
                            Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe and mini fridge.",
                            Price = 29.99m,
                            RoomNumber = 100
                        },
                        new
                        {
                            RoomId = 4,
                            Description = "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe and mini fridge.",
                            Price = 100.99m,
                            RoomNumber = 22
                        },
                        new
                        {
                            RoomId = 5,
                            Description = "Our Deluxe king size room has a seating area, ample storage, digital safe and mini fridge. This room can also be configured with an extra roll-away bed for families of 3.",
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
