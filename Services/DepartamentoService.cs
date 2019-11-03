using SiteVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendas.Services
{
    public class DepartamentoService
    {
        private readonly SiteVendasContext _context;

        public DepartamentoService(SiteVendasContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }

    }
}
