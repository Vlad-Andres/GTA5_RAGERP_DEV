﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using trueRp;

namespace trueRp.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("trueRp.Model.Contract", b =>
                {
                    b.Property<int>("ContractID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<int>("PlayerID");

                    b.Property<int>("PropertyID");

                    b.Property<int>("TypeContract");

                    b.HasKey("ContractID");

                    b.HasIndex("PlayerID");

                    b.HasIndex("PropertyID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("trueRp.Model.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("ItemCode");

                    b.Property<int>("PlayerID");

                    b.HasKey("InventoryID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("trueRp.Model.Job", b =>
                {
                    b.Property<int>("JobID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("JobID");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("trueRp.Model.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Balance");

                    b.Property<int>("InventoryID");

                    b.Property<int>("JobId");

                    b.Property<string>("Password");

                    b.Property<int>("Status");

                    b.Property<string>("Username");

                    b.HasKey("PlayerID");

                    b.HasIndex("InventoryID");

                    b.HasIndex("JobId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("trueRp.Model.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OwnerID");

                    b.HasKey("PropertyID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("trueRp.Model.Contract", b =>
                {
                    b.HasOne("trueRp.Model.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("trueRp.Model.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("trueRp.Model.Inventory", b =>
                {
                    b.HasOne("trueRp.Model.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("trueRp.Model.Player", b =>
                {
                    b.HasOne("trueRp.Model.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("trueRp.Model.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("trueRp.Model.Property", b =>
                {
                    b.HasOne("trueRp.Model.Player", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
