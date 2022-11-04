using Microsoft.EntityFrameworkCore;
using PedidoAPI.Models;

namespace PedidoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) {
        }

        public DbSet<Item> Itens { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }

    }
}