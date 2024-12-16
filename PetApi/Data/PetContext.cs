using Microsoft.EntityFrameworkCore;

namespace PetApi.Data
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; }
    }

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
    }
}
