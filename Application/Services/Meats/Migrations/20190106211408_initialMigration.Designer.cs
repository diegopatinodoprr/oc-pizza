﻿// <auto-generated />
using System;
using MeatsApi.DomainAdapters.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeatsApi.Migrations
{
    [DbContext(typeof(MigrationMeatsContext))]
    [Migration("20190106211408_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MeatsApi.DomainAdapters.Persistance.Entities.Meat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DishId");

                    b.Property<string>("Name");

                    b.Property<string>("Origin");

                    b.HasKey("Id");

                    b.ToTable("meats");
                });
#pragma warning restore 612, 618
        }
    }
}