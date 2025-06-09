using Microsoft.EntityFrameworkCore;

namespace MyStore.Business
{
    public class MyStoreDbContext : DbContext
    {
        public MyStoreDbContext(DbContextOptions<MyStoreDbContext> options) : base(options) { }

        public DbSet<AccountMember> AccountMembers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình MemberId là primary key
            modelBuilder.Entity<AccountMember>()
                .HasKey(e => e.MemberId);

            base.OnModelCreating(modelBuilder);
        }
    }
}