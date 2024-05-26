﻿// <auto-generated />
using System;
using ClothesMarkt.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    [DbContext(typeof(ClothesMarktDbContext))]
    partial class ClothesMarktDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClothesMarkt.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Renk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9763),
                            Name = "Altın"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9765),
                            Name = "Bej"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9768),
                            Name = "Beyaz"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9770),
                            Name = "Bordo"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9772),
                            Name = "Ekru"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9774),
                            Name = "Gri"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9776),
                            Name = "Gümüş"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9777),
                            Name = "Haki"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9779),
                            Name = "Kahverengi"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9781),
                            Name = "Kırmızı"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9783),
                            Name = "Lacivert"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9785),
                            Name = "Mavi"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9787),
                            Name = "Metalik"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9788),
                            Name = "Mor"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9790),
                            Name = "Pembe"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9792),
                            Name = "Sarı"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9794),
                            Name = "Siyah"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9796),
                            Name = "Turkuaz"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9797),
                            Name = "Turuncu"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9799),
                            Name = "Yeşil"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9801),
                            Name = "Çok Renkli"
                        });
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Shirt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KolBoyu")
                        .HasColumnType("int");

                    b.Property<int?>("KolTipi")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PictureFile")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ProductSize")
                        .HasColumnType("int");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtBaski")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtDesen")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtDokumaTipi")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtKalip")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtKolTipi")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtKumasTipi")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtMateryal")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtYakaTipi")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Shirts");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.ShirtsRenkler", b =>
                {
                    b.Property<int>("ShirtId")
                        .HasColumnType("int");

                    b.Property<int>("RenkId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ShirtId", "RenkId");

                    b.HasIndex("RenkId");

                    b.ToTable("ShirtsRenklers");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Tshirt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Baski")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CepTipi")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DokumaTipi")
                        .HasColumnType("int");

                    b.Property<int?>("Kalip")
                        .HasColumnType("int");

                    b.Property<int?>("KolBoyu")
                        .HasColumnType("int");

                    b.Property<int?>("KolTipi")
                        .HasColumnType("int");

                    b.Property<int?>("Materyal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PictureFile")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ProductSize")
                        .HasColumnType("int");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("YakaTipi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tshirts");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.TshirtsRenkler", b =>
                {
                    b.Property<int>("TshirtId")
                        .HasColumnType("int");

                    b.Property<int>("RenkId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("RowNum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("TshirtId", "RenkId");

                    b.HasIndex("RenkId");

                    b.ToTable("TshirtsRenklers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5a232034-7a38-46ad-8eef-df09f54a0303",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEFmOhSJvu0o4uAnOCBkEUdODc/U38w0uINglSfVzfzKQ1QEYlj2gLeLbQAlWTp3Ckg==",
                            PhoneNumber = "-",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "05ce0739-e5f0-442a-8cac-ca85d2527ef1",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Shirt", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Category", "Category")
                        .WithMany("Shirts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.ShirtsRenkler", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Renk", "Renk")
                        .WithMany("Shirts")
                        .HasForeignKey("RenkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesMarkt.Entities.Shirt", "Shirt")
                        .WithMany("Renkler")
                        .HasForeignKey("ShirtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Renk");

                    b.Navigation("Shirt");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Tshirt", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Category", "Category")
                        .WithMany("Tshirts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.TshirtsRenkler", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Renk", "Renk")
                        .WithMany("Tshirts")
                        .HasForeignKey("RenkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesMarkt.Entities.Tshirt", "Tshirt")
                        .WithMany("Renkler")
                        .HasForeignKey("TshirtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Renk");

                    b.Navigation("Tshirt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Category", b =>
                {
                    b.Navigation("Shirts");

                    b.Navigation("Tshirts");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Renk", b =>
                {
                    b.Navigation("Shirts");

                    b.Navigation("Tshirts");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Shirt", b =>
                {
                    b.Navigation("Renkler");
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Tshirt", b =>
                {
                    b.Navigation("Renkler");
                });
#pragma warning restore 612, 618
        }
    }
}
