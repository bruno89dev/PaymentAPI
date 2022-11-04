// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using PedidoAPI.Data;
// using PedidoAPI.DTO;
// using PedidoAPI.Models;

// namespace PedidoAPI.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class VendedoresController : ControllerBase
//     {
//         private readonly AppDbContext _context;

//         public VendedoresController(AppDbContext context) {
//             _context = context;
//         }

//         [HttpGet]
//         public IActionResult Listar() {
            
//             var listaVendedores = _context.Vendedores.ToList();

//             if(listaVendedores.Count > 0) {
//                 return Ok(listaVendedores);
//             }
//             return NotFound("Nenhum vendedor encontrado!");
//         }

//         [HttpPost]
//         public IActionResult CadastrarVendedor(VendedorDTO vendedorTemp) {
            
//             var vendedor = new Vendedor();

//             vendedor.Nome = vendedorTemp.Nome;
//             _context.Vendedores.Add(vendedor);
//             _context.SaveChanges();
//             Response.StatusCode = 201;
//             return new ObjectResult(new{info = "Vendedor criado com sucesso!"});
//         }       
//     }
// }