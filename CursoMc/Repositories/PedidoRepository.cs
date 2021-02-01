using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMc.Repositories
{
    public class PedidoRepository
    {
        private readonly Contexto _contexto;

        public PedidoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Pedido Buscar(int id)
        {
            return _contexto.Pedidos.Include(p => p.Cliente).Where(c => c.Id == id).SingleOrDefault();
        }
    }
}