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
    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<User> Users => Set<User>();



    // Model Configuration Using Fluent API
    protected override void OnModelCreating(ModelBuilder builder)
    {

        // Character
        builder.Entity<Character>().HasKey(e=> e.Id);        
        // Createdbyid
        builder.Entity<Character>().HasOne(e=> e.User).WithMany(e=> e.Characters)
            .HasForeignKey(e=> e.CreatedByID).IsRequired();

        // // Country ID
        // builder.Entity<Character>().HasOne(e=> e.Country).WithMany(e=> e.Characters)
        //     .HasForeignKey(e=> e.CountryId).OnDelete(DeleteBehavior.NoAction).IsRequired();

        builder.Entity<Character>().Property(e=> e.CharacterName).HasMaxLength(100).IsRequired();
        builder.Entity<Character>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");
        builder.Entity<Character>().Property(e=> e.IsActive).HasDefaultValue(true);
        // builder.Entity<Character>();

        // Country
        builder.Entity<Country>().HasKey(e=> e.Id);
        builder.Entity<Country>().Property(e=> e.CountryName).HasMaxLength(100).IsRequired();
        builder.Entity<Country>().HasIndex(e=> e.CountryName).IsUnique();
        builder.Entity<Country>().Property(e=> e.IsActive).HasDefaultValue(true);
        builder.Entity<Country>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");


        // Movie
        builder.Entity<Movie>().HasKey(e=> e.Id);
        builder.Entity<Movie>().HasOne(e=> e.User).WithMany(e=> e.Movies).HasForeignKey(e=> e.CreatedByID).IsRequired();
        builder.Entity<Movie>().Property(e=> e.Name).HasMaxLength(100).IsRequired();




        // User
        builder.Entity<User>().HasKey(e=> e.Id);
        builder.Entity<User>().Property(e=> e.FirstName).HasMaxLength(50).IsRequired();
        builder.Entity<User>().Property(e=> e.LastName).HasMaxLength(50).IsRequired();
        builder.Entity<User>().Property(e=> e.Email).HasMaxLength(150).IsRequired();
        builder.Entity<User>().HasIndex(e=> e.Email).IsUnique();
        // builder.Entity<User>().Property(e=> e.Id);


    }


}
