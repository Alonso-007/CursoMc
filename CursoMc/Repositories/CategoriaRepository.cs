using CursoMc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMc.Repositories
{
    public class CategoriaRepository
    {
        private readonly Contexto _contexto;

        public CategoriaRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Categoria Buscar(int id)
        {
            return _contexto.Categorias.Where(w => w.Id == id).FirstOrDefault();
        }
    }
}
