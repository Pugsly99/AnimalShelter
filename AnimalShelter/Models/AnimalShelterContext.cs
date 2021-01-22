using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
      public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
          : base(options)
      {
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Leith", Species = "Beagle", Gender = "Male", Age = 4},
          new Dog { DogId = 2, Name = "Marry", Species = "Poodle", Gender = "Female", Age = 1},
          new Dog { DogId = 3, Name = "Nakita", Species = "German Shepherd", Gender = "Female", Age = 6},
          new Dog { DogId = 4, Name = "Apollo", Species = "Siberian Husky", Gender = "Male", Age = 7},
          new Dog { DogId = 5, Name = "Ava", Species = "German Shepherd", Gender = "Female", Age = 5},
          new Dog { DogId = 6, Name = "Link", Species = "Beagle", Gender = "Male", Age = 4},
          new Dog { DogId = 7, Name = "Larry", Species = "Poodle", Gender = "Female", Age = 5},
          new Dog { DogId = 8, Name = "Tiger", Species = "German Shepherd", Gender = "Female", Age = 7},
          new Dog { DogId = 9, Name = "Mr.Pebbles", Species = "Siberian Husky", Gender = "Male", Age = 3},
          new Dog { DogId = 10, Name = "Rex", Species = "German Shepherd", Gender = "male", Age = 3}         
        );

      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Pippen", Species = "Persian", Gender = "Male", Age = 2},
          new Cat { CatId = 2, Name = "May", Species = "Bengal", Gender = "Female", Age = 1},
          new Cat { CatId = 3, Name = "Nala", Species = "Siamese", Gender = "Female", Age = 1},
          new Cat { CatId = 4, Name = "Niko", Species = "Ragdoll", Gender = "Male", Age = 3},
          new Cat { CatId = 5, Name = "Simba", Species = "Maine Coon", Gender = "Female", Age = 4}, 
          new Cat { CatId = 6, Name = "Mittens", Species = "Persian", Gender = "Male", Age = 6},
          new Cat { CatId = 7, Name = "Puki", Species = "Bengal", Gender = "Female", Age = 6},
          new Cat { CatId = 8, Name = "Jay", Species = "Siamese", Gender = "Female", Age = 1},
          new Cat { CatId = 9, Name = "Snuffs", Species = "Ragdoll", Gender = "Male", Age = 3},
          new Cat { CatId = 10, Name = "Kinko", Species = "Maine Coon", Gender = "Female", Age = 1} 
        );  
      }
    

      public DbSet<Dog> Dogs { get; set; }
      public DbSet<Cat> Cats { get; set; }
    }
}