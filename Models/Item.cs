using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PedidoAPI.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Venda> Venda { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

    }
}