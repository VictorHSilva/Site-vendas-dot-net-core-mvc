using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteVendas.Models
{
    public class SiteVendasContext : DbContext
    {
        public SiteVendasContext (DbContextOptions<SiteVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegVendas> RegVendas { get; set; }
    }
}
