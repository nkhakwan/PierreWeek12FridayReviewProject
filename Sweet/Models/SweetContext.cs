using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sweet.Models
{
  public class SweetContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public SweetContext(DbContextOptions options) : base(options) { }
  }
}
