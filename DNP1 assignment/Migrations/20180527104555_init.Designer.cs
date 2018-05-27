﻿// <auto-generated />
using DNP1_assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DNP1assignment.Migrations
{
    [DbContext(typeof(VIACinemaContext))]
    [Migration("20180527104555_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNP1_assignment.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CinemaId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Length");

                    b.Property<int>("MinimalAge");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Origin");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Performance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("HallId");

                    b.Property<string>("Language");

                    b.Property<int?>("MovieId");

                    b.Property<string>("Subtitles");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("HallId");

                    b.Property<int?>("PaymentId");

                    b.Property<int?>("PerformanceId");

                    b.Property<int>("XPosition");

                    b.Property<int>("YPosition");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("PerformanceId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Discount");

                    b.Property<int?>("PerformanceId");

                    b.Property<double>("Price");

                    b.Property<int?>("SeatId");

                    b.HasKey("Id");

                    b.HasIndex("PerformanceId");

                    b.HasIndex("SeatId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Hall", b =>
                {
                    b.HasOne("DNP1_assignment.Models.Cinema", "Cinema")
                        .WithMany("Halls")
                        .HasForeignKey("CinemaId");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Performance", b =>
                {
                    b.HasOne("DNP1_assignment.Models.Hall", "Hall")
                        .WithMany("Performances")
                        .HasForeignKey("HallId");

                    b.HasOne("DNP1_assignment.Models.Movie", "Movie")
                        .WithMany("Performances")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Seat", b =>
                {
                    b.HasOne("DNP1_assignment.Models.Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId");

                    b.HasOne("DNP1_assignment.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("DNP1_assignment.Models.Performance", "Performance")
                        .WithMany()
                        .HasForeignKey("PerformanceId");
                });

            modelBuilder.Entity("DNP1_assignment.Models.Ticket", b =>
                {
                    b.HasOne("DNP1_assignment.Models.Performance")
                        .WithMany("Tickets")
                        .HasForeignKey("PerformanceId");

                    b.HasOne("DNP1_assignment.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId");
                });
#pragma warning restore 612, 618
        }
    }
}
