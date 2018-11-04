﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using safari;

namespace safari.Migrations
{
    [DbContext(typeof(SafariHWContext))]
    [Migration("20181101223141_seededData")]
    partial class seededData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("safari.Models.SafariVacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfTimesSeen");

                    b.Property<string>("LocationOfLastSeen");

                    b.Property<string>("Species");

                    b.HasKey("Id");

                    b.ToTable("SafariVacation");

                    b.HasData(
                        new { Id = -1, CountOfTimesSeen = 3, LocationOfLastSeen = "watering hole", Species = "Hyena" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
