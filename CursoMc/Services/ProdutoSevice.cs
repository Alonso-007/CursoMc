using CursoMc.Model;
using CursoMc.Repositories;

namespace CursoMc.Services
{
    public class ProdutoSevice
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoSevice(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto Buscar(int id)
        {
            var obj = _produtoRepository.Buscar(id);
            return obj;
        }
    }
}