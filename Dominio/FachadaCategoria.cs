using PersistenciaLayer.Repositorios;
using Entidades.Modelos;
using Entidades.ViewModel;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FachadaCategoria
    {
        ICategoria teste = new CategoriaDAO_EF();
        
        public async Task Inserir(Movie m1)
        {
            await movieDB.Inserir(m1);
        }

        public async Task<List<Categoria>> ListMovie()
        {
            return await movieDB.List();
        }

        public async Task Delete(Movie movie)
        {
            await movieDB.Delete(movie);
        }

        public async Task<Movie> GetMovieById(int Id)
        {
            return await movieDB.GetMovieById(Id);
        }

        public async Task Update(Movie movie)
        {
            await movieDB.Update(movie);
        }


        public async Task Inserir(Genre g1)
        {
            await genreDB.Inserir(g1);
        }

        public async Task<List<Genre>> ListGenre()
        {
            return await genreDB.List();
        }

        public async Task Delete(Genre genre)
        {
            await genreDB.Delete(genre);
        }

        public async Task<Genre> GetGenreById(int Id)
        {
            return await genreDB.GetGenreById(Id);
        }

        public async Task Update(Genre genre)
        {
            await genreDB.Update(genre);
        }

        public async Task<ICollection<GenreSummary>> getRelatorioGeneros()
        {
            return await genreDB.getGenreSummary();
        }
    }
}
