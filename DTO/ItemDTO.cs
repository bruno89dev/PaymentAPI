namespace PedidoAPI.DTO
{
    public class ItemDTO
    {
        public string Descricao { get; set; }
        public int VendaId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}