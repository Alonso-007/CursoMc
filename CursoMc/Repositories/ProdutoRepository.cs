using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMc.Repositories
{
    public class ProdutoRepository
    {
        private readonly Contexto _contexto;

        public ProdutoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<Produto> Buscar(int id)
        {
            return _contexto.Produtos.Include(p => p.Categorias).Where(p => p.Id == id).ToList();
        }
    }
}
