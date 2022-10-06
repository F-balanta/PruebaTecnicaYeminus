using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using YeminusSoftware.Domain;

namespace YeminusSoftware.Infrastructure.Data
{
    public class YeminusSoftwareContext : DbContext
    {
        public YeminusSoftwareContext(DbContextOptions<YeminusSoftwareContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .Property(x => x.PriceList)
            .HasConversion(listOfIntPrices => JsonConvert.SerializeObject(listOfIntPrices),
            pricesJsonRepresentation => JsonConvert.DeserializeObject<List<int>>(pricesJsonRepresentation));
            
            modelBuilder.Entity<Product>()
            .HasData(SeedData.Products);

            modelBuilder.Entity<Product>().HasKey(
            x => new { x.Code });

            modelBuilder.Entity<Product>().Property(x => x.Code)
            .ValueGeneratedOnAdd();
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
