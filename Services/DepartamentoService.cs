using SiteVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteVendas.Services
{
    public class DepartamentoService
    {
        private readonly SiteVendasContext _context;

        public DepartamentoService(SiteVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}
