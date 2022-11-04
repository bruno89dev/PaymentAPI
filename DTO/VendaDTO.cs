using System.Collections.Generic;
using PedidoAPI.Models;

namespace PedidoAPI.DTO
{
    public class VendaDTO
    {
        public int ItemId { get; set; }
        public int VendedorId { get; set; }
        public decimal ValorTotal { get; set; }
    }
}