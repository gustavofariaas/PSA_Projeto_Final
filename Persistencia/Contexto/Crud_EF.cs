using Microsoft.EntityFrameworkCore;
using Persistencia.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Persistencia.Repositorios
{
    public class Crud_EF<T> : ICrud<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<DatabaseContext> _OptionsBuilder;

        public Crud_EF()
        {
            _OptionsBuilder = new DbContextOptions<DatabaseContext>();
        }

        public async Task Add(T Objeto)
        {
            using (var data = new DatabaseContext(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var data = new DatabaseContext(_OptionsBuilder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetEntityById(long Id)
        {
            using (var data = new DatabaseContext(_OptionsBuilder))
            {
                return await data.Set<T>().FindAsync(Id);
            }
        }

        public async Task<IEnumerable<T>> List()
        {
            using (var data = new DatabaseContext(_OptionsBuilder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var data = new DatabaseContext(_OptionsBuilder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
            }
        }

    }
}
