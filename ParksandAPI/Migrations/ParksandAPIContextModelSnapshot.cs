// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksandAPI.Models;

namespace ParksandAPI.Migrations
{
    [DbContext(typeof(ParksandAPIContext))]
    partial class ParksandAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksandAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Acreage")
                        .HasColumnType("int");

                    b.Property<string>("Activities")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("NationalPark")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("StatePark")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Acreage = 316,
                            Activities = "hiking, lake access, swimming, historic buildings, playground",
                            Address = "14445 Juanita Dr NE, Kenmore, WA 98028",
                            Name = "Saint Edward State Park",
                            NationalPark = false,
                            StatePark = true
                        },
                        new
                        {
                            ParkId = 2,
                            Acreage = 534,
                            Activities = "hiking, beach access, historic lighthouse",
                            Address = "3801 Discovery Park Blvd, Seattle, WA 98199",
                            Name = "Discovery Park",
                            NationalPark = false,
                            StatePark = false
                        },
                        new
                        {
                            ParkId = 3,
                            Acreage = 236381,
                            Activities = "hiking, mountain climbing, camping",
                            Address = "39000 State Route 706 E, Ashford, WA 98304",
                            Name = "Mount Rainier",
                            NationalPark = true,
                            StatePark = false
                        },
                        new
                        {
                            ParkId = 4,
                            Acreage = 350,
                            Activities = "walking trails, sports fields, lake access, boating, swimming, off-leash dog area, playground",
                            Address = "7400 Sand Point Way NE, Seattle, WA 98115",
                            Name = "Warren G. Magnuson Park",
                            NationalPark = false,
                            StatePark = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
