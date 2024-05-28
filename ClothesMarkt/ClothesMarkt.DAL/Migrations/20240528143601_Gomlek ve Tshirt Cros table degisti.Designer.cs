﻿// <auto-generated />
using System;
using ClothesMarkt.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    [DbContext(typeof(ClothesMarktDbContext))]
    [Migration("20240528143601_Gomlek ve Tshirt Cros table degisti")]
    partial class GomlekveTshirtCrostabledegisti
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4088),
                            Name = "Altın"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4091),
                            Name = "Bej"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4093),
                            Name = "Beyaz"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4095),
                            Name = "Bordo"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4097),
                            Name = "Ekru"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4099),
                            Name = "Gri"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4101),
                            Name = "Gümüş"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4103),
                            Name = "Haki"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4105),
                            Name = "Kahverengi"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4107),
                            Name = "Kırmızı"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4109),
                            Name = "Lacivert"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4111),
                            Name = "Mavi"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4112),
                            Name = "Metalik"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4114),
                            Name = "Mor"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4116),
                            Name = "Pembe"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4118),
                            Name = "Sarı"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4120),
                            Name = "Siyah"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4122),
                            Name = "Turkuaz"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4124),
                            Name = "Turuncu"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4125),
                            Name = "Yeşil"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4127),
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
                            ConcurrencyStamp = "ee1c0fb8-4fbf-4550-8c3c-1a02dad361ed",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEGdcRpN2hKXjVWINkaTDUunzx3/40juu8EeZZ1snDZ8sOWbODFhP+Dspau8fRV2m2g==",
                            PhoneNumber = "-",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "40409eef-95ad-4213-86ed-56efffb1b6fc",
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

            modelBuilder.Entity("RenkShirt", b =>
                {
                    b.Property<int>("RenklerId")
                        .HasColumnType("int");

                    b.Property<int>("ShirtsId")
                        .HasColumnType("int");

                    b.HasKey("RenklerId", "ShirtsId");

                    b.HasIndex("ShirtsId");

                    b.ToTable("RenkShirt");
                });

            modelBuilder.Entity("RenkTshirt", b =>
                {
                    b.Property<int>("RenklerId")
                        .HasColumnType("int");

                    b.Property<int>("TshirtsId")
                        .HasColumnType("int");

                    b.HasKey("RenklerId", "TshirtsId");

                    b.HasIndex("TshirtsId");

                    b.ToTable("RenkTshirt");
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

            modelBuilder.Entity("ClothesMarkt.Entities.Tshirt", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Category", "Category")
                        .WithMany("Tshirts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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

            modelBuilder.Entity("RenkShirt", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Renk", null)
                        .WithMany()
                        .HasForeignKey("RenklerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesMarkt.Entities.Shirt", null)
                        .WithMany()
                        .HasForeignKey("ShirtsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RenkTshirt", b =>
                {
                    b.HasOne("ClothesMarkt.Entities.Renk", null)
                        .WithMany()
                        .HasForeignKey("RenklerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesMarkt.Entities.Tshirt", null)
                        .WithMany()
                        .HasForeignKey("TshirtsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClothesMarkt.Entities.Category", b =>
                {
                    b.Navigation("Shirts");

                    b.Navigation("Tshirts");
                });
#pragma warning restore 612, 618
        }
    }
}