using Entidades.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    class VendedorDAO_EF : IDisposable
    {
        private DatabaseContext _context;
        public VendedorDAO_EF()
        {
            _context = new DatabaseContext();
        }
        public async Task Inserir(Vendedor m)
        {
            await _context.Vendedor.AddAsync(m);
            await _context.SaveChangesAsync();

        }
        public async Task Update(Vendedor m)
        {
            _context.Vendedor.Update(m);
            await _context.SaveChangesAsync();

        }
        public async Task Delete(Vendedor m)
        {
            _context.Vendedor.Remove(m);
            await _context.SaveChangesAsync();

        }

        public async Task<Vendedor> GetVendedorById(int Id)
        {
            return await _context.Vendedor.FindAsync(Id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
