using System;

namespace MovieStar.Models
{
    public class CharacterContext: DbContext{

        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {
            

        }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<Movie> Movies => Set<Movie>();
    }
}