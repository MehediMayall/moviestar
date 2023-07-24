using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStar.Models
{
    public class CharacterContext: DbContext{

        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {
            

        }


        // Models
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<Movie> Movies => Set<Movie>();

        public DbSet<User> Users => Set<User>();



        // Model Configuration Using Fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // User
            builder.Entity<User>().HasKey(e=> e.Id);
            builder.Entity<User>().HasMany(e=> e.Characters);
            builder.Entity<User>().Property(e=> e.Id).ValueGeneratedOnAdd();
            builder.Entity<User>().Property(e=> e.FirstName).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(e=> e.LastName).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(e=> e.Email).IsRequired().HasMaxLength(150);
                

            // Character
            builder.Entity<Character>().HasKey(e=>e.Id);
            builder.Entity<Character>().Property(e=> e.Id).ValueGeneratedOnAdd();
            builder.Entity<Character>().Property(e=> e.CharacterName).HasMaxLength(100);

        }




    }
}