using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyStore.Business
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyStoreDbContext>
    {
        public MyStoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyStoreDbContext>();
            
            // Dùng PostgreSQL connection string
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Username=postgres;Password=password;Database=mvc");
            
            return new MyStoreDbContext(optionsBuilder.Options);
        }
    }
}