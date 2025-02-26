﻿// <auto-generated />
using DemoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoApi.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20210913094312_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1001,
                            Name = "Book",
                            Quantity = 100,
                            UnitCost = 200m
                        },
                        new
                        {
                            ProductId = 1005,
                            Name = "Pen",
                            Quantity = 40,
                            UnitCost = 15m
                        },
                        new
                        {
                            ProductId = 1010,
                            Name = "Samsung Galaxy M31",
                            Quantity = 20,
                            UnitCost = 22999m
                        },
                        new
                        {
                            ProductId = 1015,
                            Name = "Apple Ear Buds",
                            Quantity = 12,
                            UnitCost = 7989m
                        });
                });

            modelBuilder.Entity("DemoApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "Pass@1",
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            Password = "User@123",
                            Username = "ApiUser"
                        },
                        new
                        {
                            Id = 3,
                            Password = "User@111",
                            Username = "AuthUser"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
