using CursoMc.Model;
using System.Linq;

namespace CursoMc.Repositories
{
    public class CidadeReposity
    {
        private readonly Contexto _contexto;

        public CidadeReposity(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Cidade Buscar(int id)
        {
            return _contexto.Cidades.Where(c => c.Id == id).SingleOrDefault();
        }
    }
}