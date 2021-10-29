using Microsoft.EntityFrameworkCore;

namespace ParksandAPI.Models
{
  public class ParksandAPIContext : DbContext
  { 
    public ParksandAPIContext(DbContextOptions<ParksandAPIContext> options)
      : base(options)
    { 

    }

    public DbSet<Park> Parks { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Saint Edward State Park", StatePark = true, NationalPark = false, Activities = "hiking, lake access, swimming, historic buildings, playground", Acreage = 316, Address = "14445 Juanita Dr NE, Kenmore, WA 98028"},
          new Park { ParkId = 2, Name = "Discovery Park", StatePark = false, NationalPark = false, Activities = "hiking, beach access, historic lighthouse", Acreage = 534, Address = "3801 Discovery Park Blvd, Seattle, WA 98199"},
          new Park { ParkId = 3, Name = "Mount Rainier", StatePark = false, NationalPark = true, Activities = "hiking, mountain climbing, camping", Acreage = 236381, Address = "39000 State Route 706 E, Ashford, WA 98304"},
          new Park { ParkId = 4, Name = "Warren G. Magnuson Park", StatePark = false, NationalPark = false, Activities = "walking trails, sports fields, lake access, boating, swimming, off-leash dog area, playground", Acreage = 350, Address = "7400 Sand Point Way NE, Seattle, WA 98115"}
        );
    }
  }
}