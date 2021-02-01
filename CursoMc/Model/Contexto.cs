using Microsoft.EntityFrameworkCore;

namespace CursoMc.Model
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<TipoCliente> TipoClientes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EstadoPagamento> EstadoPagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PagamentoComBoleto> PagamentoComBoletos { get; set; }
        public DbSet<PagamentoComCartao> PagamentoComCartaos { get; set; }
    }
}