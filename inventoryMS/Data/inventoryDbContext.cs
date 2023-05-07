// namespace inventoryMS.Data;
// public class Class1
// {

// }
// using Microsoft.EntityFrameworkCore;

// namespace inventoryMS.Models
// {
//     public class YourDbContext : DbContext
//     {
//         public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
//         {
//         }

//         public DbSet<Id> Ids { get; set; }
//         public DbSet<Name> Names { get; set; }
//     }
// }

using Microsoft.EntityFrameworkCore;
// using inventoryMS.Models;

namespace inventoryMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    public DbSet<InventoryItem>? InventoryItems { get; set; }

    }
}
       