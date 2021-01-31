using CursoMc.Model;
using CursoMc.Services;
using Microsoft.AspNetCore.Mvc;

namespace CursoMc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteServico _clienteService;

        public ClientesController(ClienteServico clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> Buscar(int id)
        {
            Cliente cliente = _clienteService.Buscar(id);

            if (cliente == null)
                return NotFound("Cliente nao encontrado");

            //return Ok(new { categoria.Id, categoria.Nome, categoria.Produtos });
            return Ok(cliente);
        }
    }
}