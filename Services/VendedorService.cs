﻿using SiteVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteVendas.Services.Exception;

namespace SiteVendas.Services
{
    public class VendedorService
    {
        private readonly SiteVendasContext _context;
        public VendedorService(SiteVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {
            
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
            var obj = await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();

            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException("Este vendedor não pode ser deletado por que ele tem vendas");
            }
           
        }

        public async Task UpdateAsync(Vendedor obj)
        {
          /*  bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
           if (!hasAny)
            {
                throw new NotFoudException("Id not found");
            }*/
            try
            {

            
            _context.Update(obj);
            await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message); 
            }
        }

    }
}
