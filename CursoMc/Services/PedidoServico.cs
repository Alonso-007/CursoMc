using CursoMc.Model;
using CursoMc.Repositories;
using System.Collections.Generic;

namespace CursoMc.Services
{
    public class PedidoServico
    {
        private readonly ItemPedidoRepository _itemPedidoRepository;

        public PedidoServico(ItemPedidoRepository itemPedidoRepository)
        {
            _itemPedidoRepository = itemPedidoRepository;
        }

        public List<ItemPedido> Buscar(int id)
        {
            var obj = _itemPedidoRepository.Buscar(id);
            return obj;
        }
    }
}