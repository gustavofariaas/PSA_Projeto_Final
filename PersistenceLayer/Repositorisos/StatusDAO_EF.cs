using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositorisos
{
    public class StatusDAO_EF : IDisposable
    {
        private Context _context;
        public StatusDAO_EF()
        {
            _context = new Context();
        }

        public async Task Inserir(Status m)
        {
            await _context.Status.AddAsync(m);
            await _context.SaveChangesAsync();

        }
        public async Task Update(Status m)
        {
            _context.Status.Update(m);
            await _context.SaveChangesAsync();

        }
        public async Task Delete(Status m)
        {
            _context.Status.Remove(m);
            await _context.SaveChangesAsync();

        }

        public async Task<Status> GetCategoriaById(int Id)
        {
            return await _context.Status.FindAsync(Id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
