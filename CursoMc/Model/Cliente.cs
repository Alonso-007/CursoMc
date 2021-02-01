using System.Collections.Generic;

namespace CursoMc.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CpfOuCnpj { get; set; }
        public int TipoClienteId { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public string Telefone { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}