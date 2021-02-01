using System.ComponentModel.DataAnnotations;

namespace CursoMc.Model
{
    public abstract class Pagamento
    {
        public int EstadoPagamentoId { get; set; }
        public EstadoPagamento EstadoPagamento { get; set; }
        [Key]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}