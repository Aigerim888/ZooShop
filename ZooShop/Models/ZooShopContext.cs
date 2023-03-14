using Microsoft.EntityFrameworkCore;

namespace ZooShop.Models
{
    public class ZooShopContext:DbContext
    {
        public ZooShopContext(DbContextOptions<ZooShopContext>options):base(options) 
        {

        }
        public DbSet<Brands> Brands { get; set; }   
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; } 
        public DbSet<Products> Products { get; set; }
        public DbSet<Storagees> Storagees { get; set; }
    }
    
        
    
}
