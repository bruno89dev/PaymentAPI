// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using PedidoAPI.Data;
// using PedidoAPI.DTO;
// using PedidoAPI.Models;

// namespace PedidoAPI.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class VendasController : ControllerBase
//     {
//         private readonly AppDbContext _context;

//         public VendasController(AppDbContext context) {
//             _context = context;
//         }

//         [HttpGet]
//         public IActionResult Listar() {

//             var listaVendas = _context.Vendas.ToList();

//             if(listaVendas.Count > 0) {
//                 return Ok(listaVendas);
//             }
//             return NotFound("Nenhuma venda encontrada!");
//         }

//         [HttpPost]
//         public IActionResult CadastrarVenda(VendaDTO vendaTemp) {

//             var novaVenda = new Venda();
//             var listaItems = _context.Itens.ToList();   

//             foreach(var item in listaItems) {
//                 novaVenda.ItensNoPedido.Add(item);
//             }

//             // vendaTemp.Itens.ForEach( item => {
//             //     novaVenda.ItensNoPedido.Add(item);
//             // });

//             //novaVenda.CalcularValorTotal();
//             novaVenda.VendedorId = vendaTemp.VendedorId;

//             _context.Vendas.Add(novaVenda);
//             _context.SaveChanges();
//             Response.StatusCode = 201;
//             return new ObjectResult(new {info = "Venda adicionada"});

//         }
//     }
// }