using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMc.Repositories
{
    public class ClienteRepository
    {
        private readonly Contexto _contexto;

        public ClienteRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Cliente Buscar(int id)
        {
            return _contexto.Clientes.Include(p => p.TipoCliente).Where(c => c.Id == id).SingleOrDefault();
        }
    }
}