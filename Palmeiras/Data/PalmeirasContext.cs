using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Palmeiras.Models
{
    public class PalmeirasContext : DbContext
    {
        public PalmeirasContext (DbContextOptions<PalmeirasContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
