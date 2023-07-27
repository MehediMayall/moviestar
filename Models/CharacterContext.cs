using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieStar.Models;

public class CharacterContext: DbContext{

    public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
    {
        

    }


    // Models
    public DbSet<Character> Characters => Set<Character>();
    // public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<User> Users => Set<User>();



    // Model Configuration Using Fluent API
    protected override void OnModelCreating(ModelBuilder builder)
    {
       builder.Entity<Character>().HasOne(e=> e.User).WithMany(e=> e.Characters)
        .HasForeignKey(e=> e.CreatedByID).IsRequired();
       

    }


}
