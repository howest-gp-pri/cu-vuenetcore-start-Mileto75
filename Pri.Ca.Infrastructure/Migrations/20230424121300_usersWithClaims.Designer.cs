﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pri.Ca.Infrastructure.Data;

#nullable disable

namespace Pri.Ca.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20230424121300_usersWithClaims")]
    partial class usersWithClaims
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryGame", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("CategoryGame");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            GamesId = 1
                        },
                        new
                        {
                            CategoriesId = 2,
                            GamesId = 1
                        },
                        new
                        {
                            CategoriesId = 3,
                            GamesId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            GamesId = 2
                        },
                        new
                        {
                            CategoriesId = 3,
                            GamesId = 2
                        },
                        new
                        {
                            CategoriesId = 2,
                            GamesId = 2
                        },
                        new
                        {
                            CategoriesId = 1,
                            GamesId = 3
                        },
                        new
                        {
                            CategoriesId = 2,
                            GamesId = 3
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasData(
                        new
                        {
                            Id = 101,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "Admin",
                            UserId = "666"
                        },
                        new
                        {
                            Id = 102,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth",
                            ClaimValue = "19/02/1975 0:00:00",
                            UserId = "666"
                        },
                        new
                        {
                            Id = 103,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "User",
                            UserId = "667"
                        },
                        new
                        {
                            Id = 104,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth",
                            ClaimValue = "19/02/2010 0:00:00",
                            UserId = "667"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = "666",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af5e2e53-b9f9-41bc-94d7-d73707ec4466",
                            DateOfBirth = new DateTime(1975, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mileto@games.com",
                            EmailConfirmed = false,
                            Firstname = "Mileto",
                            Lastname = "Di Marco",
                            LockoutEnabled = false,
                            NormalizedEmail = "MILETO@GAMES.COM",
                            NormalizedUserName = "MILETO@GAMES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENCCL8kcrgH3lzyy0pSBwbMx1wi0u0mcFGWYlnW2qRwilZh1IGkF7sD6I7tZWtXhhg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "78656d55-78dd-47c2-b15c-54c9563b7636",
                            TwoFactorEnabled = false,
                            UserName = "mileto@games.com"
                        },
                        new
                        {
                            Id = "667",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1e10dfc1-0d69-4cbb-8c18-6b7a0f8a60e2",
                            DateOfBirth = new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luca@games.com",
                            EmailConfirmed = false,
                            Firstname = "Luca",
                            Lastname = "Di Marco",
                            LockoutEnabled = false,
                            NormalizedEmail = "LUCA@GAMES.COM",
                            NormalizedUserName = "LUCA@GAMES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHaX2+YAiZJa6LpFjjWBbY+c8WW9fqyQZWbT0HeWZIfcMdkQLSfZ2EXBJTh4hxVNqA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9dad6d32-c732-41dc-8e4f-0f384ffb24a2",
                            TwoFactorEnabled = false,
                            UserName = "luca@games.com"
                        });
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kids"
                        });
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fifa2000"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wolfenstein"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Minecraft"
                        });
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("GameId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            GameId = 2,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            GameId = 3,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 4,
                            GameId = 1,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 5,
                            GameId = 2,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 6,
                            GameId = 3,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 7,
                            GameId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 8,
                            GameId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 9,
                            GameId = 3,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 10,
                            GameId = 1,
                            Quantity = 13
                        },
                        new
                        {
                            Id = 12,
                            GameId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 13,
                            GameId = 3,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 14,
                            GameId = 1,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 15,
                            GameId = 2,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 16,
                            GameId = 3,
                            Quantity = 23
                        },
                        new
                        {
                            Id = 17,
                            GameId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 18,
                            GameId = 2,
                            Quantity = 7
                        },
                        new
                        {
                            Id = 19,
                            GameId = 3,
                            Quantity = 9
                        },
                        new
                        {
                            Id = 20,
                            GameId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 21,
                            GameId = 2,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 22,
                            GameId = 3,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 23,
                            GameId = 1,
                            Quantity = 9
                        },
                        new
                        {
                            Id = 24,
                            GameId = 2,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 25,
                            GameId = 3,
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("CategoryGame", b =>
                {
                    b.HasOne("Pri.Ca.Core.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pri.Ca.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
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
                    b.HasOne("Pri.Ca.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pri.Ca.Core.Entities.ApplicationUser", null)
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

                    b.HasOne("Pri.Ca.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pri.Ca.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Rating", b =>
                {
                    b.HasOne("Pri.Ca.Core.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Ratings")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Pri.Ca.Core.Entities.Game", "Game")
                        .WithMany("Ratings")
                        .HasForeignKey("GameId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Sale", b =>
                {
                    b.HasOne("Pri.Ca.Core.Entities.Game", "Game")
                        .WithMany("Sales")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Pri.Ca.Core.Entities.Game", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
