//using Entidades.Modelos;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace PersistenceLayer.Repositorisos
//{
//    public class UsuarioDAO_EF : IDisposable
//    {
//        private Context _context;
//        public UsuarioDAO_EF()
//        {
//            _context = new Context();
//        }

//        public async Task Inserir(Usuario m)
//        {
//            await _context.Usuarios.AddAsync(m);
//            await _context.SaveChangesAsync();

//        }
//        public async Task Update(Usuario m)
//        {
//            _context.Usuarios.Update(m);
//            await _context.SaveChangesAsync();

//        }
//        public async Task Delete(Usuario m)
//        {
//            _context.Usuarios.Remove(m);
//            await _context.SaveChangesAsync();

//        }

//        public async Task<Usuario> GetCategoriaById(int Id)
//        {
//            return await _context.Usuarios.FindAsync(Id);

//        }

//        public void Dispose()
//        {
//            throw new NotImplementedException();
//        }

//    }
//}
