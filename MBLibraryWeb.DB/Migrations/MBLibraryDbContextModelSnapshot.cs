﻿// <auto-generated />
using System;
using MBLibraryWeb.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MBLibraryWeb.DB.Migrations
{
    [DbContext(typeof(MBLibraryDbContext))]
    partial class MBLibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MBLibraryWeb.DB.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Robert Louis Stevenson",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 39, DateTimeKind.Local).AddTicks(3642),
                            CreatedBy = "initialSeedTest",
                            Genre = 1,
                            Title = "Treasure Island"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Steve Martin",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4589),
                            CreatedBy = "initialSeedTest",
                            Genre = 2,
                            Title = "Born Standing Up"
                        },
                        new
                        {
                            Id = 3,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4621),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Philosopher's Stone"
                        },
                        new
                        {
                            Id = 4,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4625),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Chamber of Secrets"
                        },
                        new
                        {
                            Id = 5,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4628),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Prisoner of Azkaban"
                        },
                        new
                        {
                            Id = 6,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4631),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Goblet of Fire"
                        },
                        new
                        {
                            Id = 7,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4634),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Order of the Phoenix"
                        },
                        new
                        {
                            Id = 8,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4637),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Half-Blood Prince"
                        },
                        new
                        {
                            Id = 9,
                            Author = "J. K. Rowling",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4640),
                            CreatedBy = "initialSeedTest",
                            Genre = 5,
                            Title = "Harry Potter and the Deathly Hallows"
                        },
                        new
                        {
                            Id = 10,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4643),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Leviathan Wakes"
                        },
                        new
                        {
                            Id = 11,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4646),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Caliban's War"
                        },
                        new
                        {
                            Id = 12,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4650),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Abaddon's Gate"
                        },
                        new
                        {
                            Id = 13,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4653),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Cibola Burn"
                        },
                        new
                        {
                            Id = 14,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4656),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Nemesis Games"
                        },
                        new
                        {
                            Id = 15,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4659),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Babylon's Ashes"
                        },
                        new
                        {
                            Id = 16,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4662),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Persepolis Rising"
                        },
                        new
                        {
                            Id = 17,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4665),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Tiamat's Wrath"
                        },
                        new
                        {
                            Id = 18,
                            Author = "James S. A. Corey",
                            CreatedAt = new DateTime(2022, 1, 13, 21, 32, 50, 41, DateTimeKind.Local).AddTicks(4668),
                            CreatedBy = "initialSeedTest",
                            Genre = 11,
                            Title = "Leviathan Falls"
                        });
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.Address", b =>
                {
                    b.HasOne("MBLibraryWeb.DB.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.Email", b =>
                {
                    b.HasOne("MBLibraryWeb.DB.Models.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.PhoneNumber", b =>
                {
                    b.HasOne("MBLibraryWeb.DB.Models.User", "User")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MBLibraryWeb.DB.Models.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Emails");

                    b.Navigation("PhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
