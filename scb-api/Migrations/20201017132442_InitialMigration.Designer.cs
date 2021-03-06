﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using scb_api.Models;

namespace scb_api.Migrations
{
    [DbContext(typeof(ScbDbContext))]
    [Migration("20201017132442_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("scb_api.Models.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("scb_api.Models.Entities.NewBorn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("RegionId");

                    b.ToTable("NewBorns");
                });

            modelBuilder.Entity("scb_api.Models.Entities.Region", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("scb_api.Models.Entities.NewBorn", b =>
                {
                    b.HasOne("scb_api.Models.Entities.Gender", "Gender")
                        .WithMany("Borns")
                        .HasForeignKey("GenderId");

                    b.HasOne("scb_api.Models.Entities.Region", "Region")
                        .WithMany("Borns")
                        .HasForeignKey("RegionId");
                });
#pragma warning restore 612, 618
        }
    }
}
