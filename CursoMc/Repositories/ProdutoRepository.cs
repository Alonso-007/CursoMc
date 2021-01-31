using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMc.Repositories
{
    public class ProdutoRepository
    {
        private readonly Contexto _contexto;

        public ProdutoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Produto Buscar(int id)
        {
            return _contexto.Produtos.Include(p => p.Categorias).Where(p => p.Id == id).SingleOrDefault();
        }
    }
}
