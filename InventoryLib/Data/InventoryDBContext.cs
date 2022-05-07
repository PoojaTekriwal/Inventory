using InventoryLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Data
{
    public class InventoryDBContext: DbContext
    {
        public InventoryDBContext(DbContextOptions<InventoryDBContext> options) : base(options)
        {
            Database.SetCommandTimeout(1000);
        }

        public DbSet<Inventory> GetInventoryResult { get; set; }
       
        protected override void OnModelCreating(ModelBuilder foModelBuilder)
        {
            foModelBuilder.Entity<Inventory>().HasNoKey();
           


        }
    }
}
