using Microsoft.EntityFrameworkCore;


namespace AnimalShelterApi.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal
        {
          AnimalId = 1,
          Name = "Abby",
          Age = 7,
          Species = "Dog",
          About = "Insane in the membrane and loves long walks off short docks"
        },
        new Animal
        {
          AnimalId = 2,
          Name = "Bella",
          Age = 11,
          Species = "Dog",
          About = "Sweet girl can never play enough fetch"
        },
        new Animal
        {
          AnimalId = 3,
          Name = "Lemon",
          Age = 5,
          Species = "Kitty",
          About = "Will keep your home safe from rats and birds"
        });
}
  }
}