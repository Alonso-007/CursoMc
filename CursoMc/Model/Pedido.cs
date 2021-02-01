using System;

namespace CursoMc.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
