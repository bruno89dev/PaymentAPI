using System.Collections.Generic;

namespace PedidoAPI.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Venda> Venda { get; set; }
    }
}