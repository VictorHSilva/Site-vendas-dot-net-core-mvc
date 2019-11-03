using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteVendas.Models;



namespace SiteVendas.Data
{
    public class SeedingService
    {
        private SiteVendasContext _context;

        public SeedingService(SiteVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
           /*  if (_context.Vendedor.Any() ||

                _context.Departamento.Any() ||
                 
                 _context.RegVendas.Any())
             {
                 return; // DB has been seeded
             }*/
             


            Departamento d1 = new Departamento(1, "Computers");
                Departamento d2 = new Departamento(2, "Eletronics");
                Departamento d3 = new Departamento(3, "Fashion");
                Departamento d4 = new Departamento(4, "Books");

                Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@hotmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
                Vendedor s2 = new Vendedor(2, "Joaquim", "joaquim@hotmail.com", new DateTime(1978, 11, 21), 2000.0, d2);
                Vendedor s3 = new Vendedor(3, "Pedro", "pedro@hotmail.com", new DateTime(1968, 4, 11), 15000.0, d3);
                Vendedor s4 = new Vendedor(4, "Bino", "bino@hotmail.com", new DateTime(1928, 4, 1), 900.0, d4);

                RegVendas r1 = new RegVendas(1, new DateTime(2018, 09, 25), 11000.0, RegStatus.Faturado, s1);
                RegVendas r2 = new RegVendas(2, new DateTime(2018, 09, 25), 1000.0, RegStatus.Faturado, s2);
                RegVendas r3 = new RegVendas(3, new DateTime(2018, 09, 25), 9000.0, RegStatus.Faturado, s3);
                RegVendas r4 = new RegVendas(4, new DateTime(2018, 09, 25), 15000.0, RegStatus.Faturado, s4);

            /*   _context.Departamento.AddRange(d1, d2, d3, d4);
                _context.Vendedor.AddRange(s1, s2, s3, s4);
                _context.RegVendas.AddRange(r1, r2, r3, r4);

                _context.SaveChanges();*/
            

        }
    }
}
