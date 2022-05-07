using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class CRMContext : DbContext
    {
        public CRMContext() : base("CrmConnection") { }

        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
