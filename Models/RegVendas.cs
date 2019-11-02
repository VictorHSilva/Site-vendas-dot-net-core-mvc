using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendas.Models
{
    public class RegVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double  Montante { get; set; }
        public RegStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegVendas()
        {
        }

        public RegVendas(int id, DateTime data, double montante, RegStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
