﻿// <auto-generated />
using System;
using InventoryLib.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryLib.Migrations
{
    [DbContext(typeof(InventoryDBContext))]
    partial class InventoryDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryLib.Models.Inventory", b =>
                {
                    b.Property<decimal?>("dcPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("inInventoryId")
                        .HasColumnType("int");

                    b.Property<string>("stDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stInventoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("unInventoryID")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("Inventory", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}