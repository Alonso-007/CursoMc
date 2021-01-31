using CursoMc.Model;
using CursoMc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CursoMc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly CategoriaService _categoriaService;

        public CategoriasController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet("{id}")]
        public ActionResult<Categoria> Buscar(int id)
        {
            Categoria categoria = _categoriaService.Buscar(id);

            if (categoria == null)
                return NotFound("Categoria nao encontrada");

            return Ok(new { categoria.Id, categoria.Nome, categoria.Produtos });
            //return Ok(categoria);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Listar()
        {
            Categoria cat1 = new Categoria()
            {
                Id = 1,
                Nome = "Informática"
            };

            Categoria cat2 = new Categoria()
            {
                Id = 2,
                Nome = "Escritório"
            };

            List<Categoria> lista = new List<Categoria>();
            lista.Add(cat1);
            lista.Add(cat2);

            return Ok(lista);
        }
    }
}