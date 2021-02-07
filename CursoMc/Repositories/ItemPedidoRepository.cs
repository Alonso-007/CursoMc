using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CursoMc.Repositories
{
    public class ItemPedidoRepository
    {
        private readonly Contexto _contexto;

        public ItemPedidoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<ItemPedido> Buscar(int id)
        {
            return _contexto.ItemPedidos
                    .Include(p => p.Pedido)
                    .Include(p => p.Produto)
                    .Where(p => p.PedidoId == id).ToList();
        }
    }
}