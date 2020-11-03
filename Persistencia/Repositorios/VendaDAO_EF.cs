using Entidades.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    class VendaDAO_EF : IDisposable
    {
        private DatabaseContext _context;
        public VendaDAO_EF()
        {
            _context = new DatabaseContext();
        }
        public async Task Inserir(Venda m)
        {
            await _context.Venda.AddAsync(m);
            await _context.SaveChangesAsync();

        }
        public async Task Update(Venda m)
        {
            _context.Venda.Update(m);
            await _context.SaveChangesAsync();

        }
        public async Task Delete(Venda m)
        {
            _context.Venda.Remove(m);
            await _context.SaveChangesAsync();

        }

        public async Task<Venda> GetVendaById(int Id)
        {
            return await _context.Venda.FindAsync(Id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
