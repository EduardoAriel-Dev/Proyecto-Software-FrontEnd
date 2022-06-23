using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Data.Queries
{
    class QueriesLibrosStock
    {
        public List<Libros> ListaLibros()
        {
            using (var Contexto = new MyDbContext())
            {
                var LibroEnStock = Contexto.libros.Where(X => X.Stock > 0).ToList();
                return LibroEnStock;
            }
        }

        public Libros Libro_Idx(string _ISBN)
        {
            using (var Contexto = new MyDbContext())
            {
                var l = Contexto.libros.Where(X => X.ISBN == _ISBN).FirstOrDefault();
                return l;
            }
        }
    }
}
