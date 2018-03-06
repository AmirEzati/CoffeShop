using RailWayCoffee.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayCoffee.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() :
            base("name=RailWayCoffeeConnection")
        {
        }

        #region Entities
        public DbSet<Order> Orders { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new Order.Configuration());
        }
    }
}
