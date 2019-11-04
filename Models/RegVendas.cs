﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendas.Models
{
    public class RegVendas
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
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
