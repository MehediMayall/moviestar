using System;

namespace MovieStar.Models
{
    public class ModelContext: DbContext{

        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
            

        }

        public DbSet<Character> Characters => Set<Character>();
    }
}