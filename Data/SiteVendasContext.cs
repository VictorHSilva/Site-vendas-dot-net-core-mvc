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

        public DbSet<SiteVendas.Models.Departamento> Departamento { get; set; }
    }
}
