using CursoMc.Model;
using CursoMc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CursoMc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoServico _pedidoServico;

        public PedidoController(PedidoServico pedidoServico)
        {
            _pedidoServico = pedidoServico;
        }

        [HttpGet("{id}")]
        public ActionResult<List<ItemPedido>> Buscar(int id)
        {
            var pedidos = _pedidoServico.Buscar(id);

            if (!pedidos.Any())
                return NotFound("Pedidos nao encontrados");

            //return Ok(new { categoria.Id, categoria.Nome, categoria.Produtos });
            return Ok(pedidos);
        }
    }
}