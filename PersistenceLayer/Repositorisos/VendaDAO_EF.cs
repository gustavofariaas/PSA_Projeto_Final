using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositorisos
{
    public class VendaDAO_EF : IDisposable
    {
        private Context _context;
        public VendaDAO_EF()
        {
            _context = new Context();
        }
        public async Task Inserir(Venda m)
        {
            await _context.Vendas.AddAsync(m);
            await _context.SaveChangesAsync();

        }
        public async Task Update(Venda m)
        {
            _context.Vendas.Update(m);
            await _context.SaveChangesAsync();

        }
        public async Task Delete(Venda m)
        {
            _context.Vendas.Remove(m);
            await _context.SaveChangesAsync();

        }

        public async Task<Venda> GetVendaById(int Id)
        {
            return await _context.Vendas.FindAsync(Id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
