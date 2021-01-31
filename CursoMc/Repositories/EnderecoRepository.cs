using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMc.Repositories
{
    public class EnderecoRepository
    {
        private readonly Contexto _contexto;

        public EnderecoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Endereco Buscar(int id)
        {
            return _contexto.Enderecos.Include(p => p.Cliente).Include(t => t.Cliente).Where(c => c.Id == id).SingleOrDefault();
        }
    }
}