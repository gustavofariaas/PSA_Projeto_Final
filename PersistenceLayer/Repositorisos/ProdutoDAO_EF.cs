using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositorisos
{
    public class ProdutoDAO_EF : IDisposable
    {
        private Context _context;
        public ProdutoDAO_EF()
        {
            _context = new Context();
        }

        public async Task Inserir(Produto m)
        {
            await _context.Produtos.AddAsync(m);
            await _context.SaveChangesAsync();

        }
        public async Task Update(Produto m)
        {
            _context.Produtos.Update(m);
            await _context.SaveChangesAsync();

        }
        public async Task Delete(Produto m)
        {
            _context.Produtos.Remove(m);
            await _context.SaveChangesAsync();

        }

        public async Task<Produto> GetCategoriaById(int Id)
        {
            return await _context.Produtos.FindAsync(Id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
