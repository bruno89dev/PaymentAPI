using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PedidoAPI.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public ICollection<Item> Itens { get; set; }
        public Vendedor Vendedor { get; set; }
        public decimal ValorTotal { get; set; }

    }
}