using CursoMc.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
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