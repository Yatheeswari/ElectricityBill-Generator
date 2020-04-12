using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ElectricityBillGeneration.Models
{
    public class EBBillContext : DbContext
    {
        public EBBillContext() : base("name=ElectricityBillConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<ElectricityBill> ElecricityBill { get; set; }
    }
}