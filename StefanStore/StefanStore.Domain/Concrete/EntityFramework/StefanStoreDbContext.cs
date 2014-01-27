using System.Data.Entity;

namespace StefanStore.Domain.Concrete
{
    public class StefanStoreDbContext : DbContext
    {
        public StefanStoreDbContext()
            : base("Name=StefanStore") //this is the connection string name
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
