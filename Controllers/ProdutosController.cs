// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using PedidoAPI.Data;
// using PedidoAPI.DTO;
// using PedidoAPI.Models;

// namespace PedidoAPI.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class ProdutosController : ControllerBase
//     {
//         private readonly AppDbContext _context;
//         public ProdutosController(AppDbContext context) {
//             _context = context;
//         }

//         [HttpGet]
//         public IActionResult Listar() {

//             var listaProdutos = _context.Produtos.ToList();

//             if(listaProdutos.Count > 0) {
//                 return Ok(listaProdutos);
//             }
//             return NotFound("Nenhum item encontrado!");
//         }

//         [HttpPost]
//         public IActionResult CadastrarProduto(ProdutoDTO produtoTemp) {

//             var produto = new Produto();

//             produto.Nome = produtoTemp.Nome;
//             produto.Valor = produtoTemp.Valor;
//             _context.Produtos.Add(produto);
//             _context.SaveChanges();
//             Response.StatusCode = 201;
//             return new ObjectResult(new{info = "Produto criado com sucesso"});

//         }
//     }
// }