using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMc.Repositories
{
    public class EstadoRepository
    {
        private readonly Contexto _contexto;

        public EstadoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Estado Buscar(int id)
        {
            return _contexto.Estados.Include(c => c.Cidades).Where(e => e.Id == id).SingleOrDefault();
        }
    }
}