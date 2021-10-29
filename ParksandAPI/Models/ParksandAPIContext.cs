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
  }
}