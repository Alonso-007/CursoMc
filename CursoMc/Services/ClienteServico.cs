using CursoMc.Model;
using CursoMc.Repositories;

namespace CursoMc.Services
{
    public class ClienteServico
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteServico(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Buscar(int id)
        {
            Cliente obj = _clienteRepository.Buscar(id);
            return obj;
        }
    }
}