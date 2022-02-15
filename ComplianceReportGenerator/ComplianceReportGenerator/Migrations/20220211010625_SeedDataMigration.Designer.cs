﻿// <auto-generated />
using System;
using ComplianceReportGenerator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComplianceReportGenerator.Migrations
{
    [DbContext(typeof(ReportDbContext))]
    [Migration("20220211010625_SeedDataMigration")]
    partial class SeedDataMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("ComplianceReportGenerator.Models.Citation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<string>("Chapter")
                        .HasColumnType("text");

                    b.Property<int>("HighPenalty")
                        .HasColumnType("int");

                    b.Property<int>("LowPenalty")
                        .HasColumnType("int");

                    b.Property<string>("Recommendation")
                        .HasColumnType("text");

                    b.Property<string>("Section")
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Citations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "“Cannabis” has the meaning ascribed to the term “marijuana” in NRS 453.096",
                            Chapter = "678A",
                            HighPenalty = 90000,
                            LowPenalty = 10000,
                            Recommendation = "Several product labels were observed with the word “marijuana,” rather than the required word “cannabis.”  The CCB has been clear since their takeover in July 2020 that all use of the word marijuana must be phased out, definitely by July 2021. Please refer to the attached picture and communicate with vendors to correct their labels and packaging as soon as possible.",
                            Section = "085",
                            Summary = "“Cannabis” defined.",
                            Type = "NRS"
                        },
                        new
                        {
                            Id = 2,
                            Body = "Each cannabis product manufacturing facility shall ensure that: surfaces of equipment and utensils that have direct contact with cannabis products are clean to sight and touch; 2.The surfaces of cooking equipment and pans that have direct contact with cannabis products are kept free of encrusted grease deposits and other soil accumulations; and 3.The surfaces of equipment that do not have direct contact with cannabis products are kept free of an accumulation of dust, dirt, residue and other debris.",
                            Chapter = "9",
                            HighPenalty = 80000,
                            LowPenalty = 5000,
                            Recommendation = "We discussed numerous items directly in touch with cannabis. Please clean and maintain the interior of the freeze dryer in the hash room, and the mixing bowls in the chocolate room. We discussed a number of solutions to keep those surfaces cleaned and maintained. Please see pictures.",
                            Section = "085",
                            Summary = "Surfaces of equipment and utensils: Cleanliness.",
                            Type = "NCCR"
                        },
                        new
                        {
                            Id = 3,
                            Body = "1.	Each cannabis establishment shall ensure that any building used to manufacture, process, package or hold cannabis or cannabis products: (a) Is of suitable size, construction and location to facilitate cleaning, maintenance and proper operations;[…] 2.Each cannabis establishment shall ensure that: (a)The flow of components, product containers, closures, labels, in-process materials and cannabis and cannabis products through any building used to manufacture, process, package or hold cannabis or cannabis products is designed to prevent contamination; (b)The operations of the cannabis establishment are performed within specifically defined areas of adequate size; (c)All items are stored at least 6 inches(15 cm) off the floor;[…] ",
                            Chapter = "10",
                            HighPenalty = 80000,
                            LowPenalty = 5000,
                            Recommendation = "In the extraction room, we observed a large container, a cooler and a bucket on the floor. These are minor issues but CCB has recently been citing facilities for not having all items in storage 6 inches above the floor. Please find another location for these items if at all possible.",
                            Section = "005",
                            Summary = "Cannabis establishment: Requirements for building used to manufacture, process, package or hold cannabis.",
                            Type = "NCCR"
                        },
                        new
                        {
                            Id = 4,
                            Body = "Each cannabis cultivation facility, cannabis product manufacturing facility and cannabis sales facility shall ensure that: 1.It has written procedures describing in sufficient detail the receipt, identification, storage, handling, sampling, testing and approval or rejection of components, product containers and closures and that it follows those procedures.A copy of these procedures shall be provided promptly to the Board or Board Agents upon request; 2.Components, product containers and closures are at all times handled and stored in a manner so as to prevent contamination;[…] ",
                            Chapter = "10",
                            HighPenalty = 90000,
                            LowPenalty = 10000,
                            Recommendation = "During the walkthrough, we found most areas clean and organized. We did find some ethanol spray bottles without labels. Please label all spray bottles and containers that are no longer in the original container.",
                            Section = "035",
                            Summary = "Cannabis cultivation facility, cannabis product manufacturing facility and cannabis sales facility: Establishment of and adherence to written procedures for components, product containers and closures. ",
                            Type = "NCCR"
                        },
                        new
                        {
                            Id = 5,
                            Body = "[…] 5.Each cannabis establishment, except a cannabis independent testing laboratory, shall establish and implement an inventory control system that documents: […] (9) The disposal of cannabis that is not usable cannabis, including: (I)A description of and reason for the cannabis being disposed of, including, if applicable, the number of failed or other unusable cannabis plants; (II)The date of disposal; (III)Confirmation that the cannabis was rendered unusable before disposal; (IV)The method of disposal; and (V) The name and the number of the cannabis establishment agent registration card of the cannabis establishment agent responsible for the disposal. ",
                            Chapter = "6",
                            HighPenalty = 90000,
                            LowPenalty = 10000,
                            Recommendation = "As trained while onsite, for your waste logs, please specify the disposal method. Maybe a check box? It’s either kitty litter or bokashi, but it cannot be both (reference photo 9).",
                            Section = "080",
                            Summary = "Inventory control system; authorized sources for acquisition of cannabis and cannabis products; duties of establishment if loss incurred; maintenance and availability of documentation.",
                            Type = "NCCR"
                        });
                });

            modelBuilder.Entity("ComplianceReportGenerator.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("ComplianceReportGenerator.Models.Test2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tests2");
                });

            modelBuilder.Entity("ComplianceReportGenerator.Models.Test3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Pastry")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tests3");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
#pragma warning restore 612, 618
        }
    }
}