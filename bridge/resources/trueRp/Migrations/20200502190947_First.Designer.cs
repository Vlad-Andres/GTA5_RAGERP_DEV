﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using trueRp;

namespace trueRp.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20200502190947_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("trueRp.Model.Contract", b =>
                {
                    b.Property<int>("contractID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("date")
                        .HasColumnType("Date");

                    b.Property<int>("playerID");

                    b.Property<int>("propertyID");

                    b.HasKey("contractID");

                    b.HasIndex("playerID");

                    b.HasIndex("propertyID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("trueRp.Model.Inventory", b =>
                {
                    b.Property<int>("inventoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("playerID");

                    b.HasKey("inventoryID");

                    b.HasIndex("playerID")
                        .IsUnique();

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("trueRp.Model.Item", b =>
                {
                    b.Property<int>("itemID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("code");

                    b.Property<int?>("inventoryID");

                    b.Property<string>("name");

                    b.HasKey("itemID");

                    b.HasIndex("inventoryID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("trueRp.Model.Player", b =>
                {
                    b.Property<int>("playerID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("balance");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("playerID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("trueRp.Model.Property", b =>
                {
                    b.Property<int>("propertyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ownerID");

                    b.HasKey("propertyID");

                    b.HasIndex("ownerID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("trueRp.Model.Contract", b =>
                {
                    b.HasOne("trueRp.Model.Player", "player")
                        .WithMany()
                        .HasForeignKey("playerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("trueRp.Model.Property", "property")
                        .WithMany()
                        .HasForeignKey("propertyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("trueRp.Model.Inventory", b =>
                {
                    b.HasOne("trueRp.Model.Player")
                        .WithOne("inventory")
                        .HasForeignKey("trueRp.Model.Inventory", "playerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("trueRp.Model.Item", b =>
                {
                    b.HasOne("trueRp.Model.Inventory")
                        .WithMany("items")
                        .HasForeignKey("inventoryID");
                });

            modelBuilder.Entity("trueRp.Model.Property", b =>
                {
                    b.HasOne("trueRp.Model.Player", "owner")
                        .WithMany()
                        .HasForeignKey("ownerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
