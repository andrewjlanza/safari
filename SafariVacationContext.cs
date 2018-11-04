using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using safari.Models;

namespace safari
{
  public partial class SafariHWContext : DbContext
  {
    public SafariHWContext()
    {
    }

    public SafariHWContext(DbContextOptions<SafariHWContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=SafariHW");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<SafariVacation>().HasData(
      new SafariVacation { Id = -1, Species = "Hyena", CountOfTimesSeen = 3, LocationOfLastSeen = "watering hole" },
      new SafariVacation { Id = -2, Species = "Lelephant", CountOfTimesSeen = 2, LocationOfLastSeen = "Serengeti" }

       );

    }
    public DbSet<SafariVacation> SafariVacation { get; set; }
  }
}
