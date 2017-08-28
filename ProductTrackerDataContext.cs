using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker
{
    public class ProductTrackerDataContext : DbContext
    {
        public ProductTrackerDataContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductHistory> ProductHistories { get; set; }

        public DbSet<KeywordHistory> KeywordHistories { get; set; }
    }   
}
