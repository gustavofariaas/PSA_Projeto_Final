using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositorisos
{
    public class CategoriaDAO_EF : IDisposable
    {
        private Context _context;
        public CategoriaDAO_EF()
        {
            _context = new Context();
        }

        public async Task Inserir(Categoria m)
        {
            await _context.Categorias.AddAsync(m);
            await _context.SaveChangesAsync();

        }
        public async Task Update(Categoria m)
        {
            _context.Categorias.Update(m);
            await _context.SaveChangesAsync();

        }
        public async Task Delete(Categoria m)
        {
            _context.Categorias.Remove(m);
            await _context.SaveChangesAsync();

        }

        public async Task<Categoria> GetCategoriaById(int Id)
        {
            return await _context.Categorias.FindAsync(Id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
