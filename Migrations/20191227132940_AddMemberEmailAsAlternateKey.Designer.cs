﻿// <auto-generated />
using System;
using Garage2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Garage2.Migrations
{
    [DbContext(typeof(GarageContext))]
    [Migration("20191227132940_AddMemberEmailAsAlternateKey")]
    partial class AddMemberEmailAsAlternateKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage2.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.HasAlternateKey("Email");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberId = 1,
                            CityAddress = "Lindevägen 60 Enskede Gård",
                            Email = "henning.oden@outlook.com",
                            FirstName = "Henning",
                            LastName = "Odén",
                            PhoneNumber = "0739753838"
                        });
                });

            modelBuilder.Entity("Garage2.Models.ParkedVehicle", b =>
                {
                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("NumberOfWheels")
                        .HasColumnType("int");

                    b.Property<DateTime>("ParkingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("RegistrationNumber");

                    b.HasIndex("MemberId");

                    b.ToTable("ParkedVehicles");

                    b.HasData(
                        new
                        {
                            RegistrationNumber = "PAY276",
                            Colour = "Red",
                            Manufacturer = "Skoda",
                            MemberId = 1,
                            Model = "Fabia Combi 1.2 TSI",
                            NumberOfWheels = 4,
                            ParkingDate = new DateTime(2019, 12, 26, 19, 8, 27, 0, DateTimeKind.Unspecified),
                            Type = 0
                        });
                });

            modelBuilder.Entity("Garage2.Models.ParkedVehicle", b =>
                {
                    b.HasOne("Garage2.Models.Member", null)
                        .WithMany("OwnedVehicles")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
