using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMc.Repositories
{
    public class CategoriaRepository
    {
        private readonly Contexto _contexto;

        public CategoriaRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Categoria Buscar(int id)
        {
            return _contexto.Categorias.Include(p => p.Produtos).Where(c => c.Id == id).SingleOrDefault();
        }
    }
}
