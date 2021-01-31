using CursoMc.Model;
using CursoMc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMc.Services
{
    public class CategoriaService
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaService(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Categoria Buscar(int id)
        {
            Categoria obj = _categoriaRepository.Buscar(id);
            return obj;
        }
    }
}