using API_ProjetoBimestral.Models;
using API_ProjetoBimestral.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ProjetoBimestral.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : Controller
    {
        ConnectionContextDB context = new ConnectionContextDB();
        [HttpGet]
        public async Task<IActionResult> getUsers()
        {
            var clientes = await context.Cliente.ToListAsync();
            return Ok(clientes);
        }
        [HttpGet("{email}&&{senha}")]
        public async Task<IActionResult> loginUser(string email, string senha)
        {
            var clientes = await context.Cliente.Where(cliente => cliente.senha == senha && cliente.email == email).SingleOrDefaultAsync();
            if(clientes != null)
            {
                return Ok(clientes);
            }
            return BadRequest();
        }
        [HttpPost]
        public async void createCliente(ClienteModel cliente)
        {
            await context.Cliente.AddAsync(cliente);
            await context.SaveChangesAsync();
        }

        [HttpPost("carrinho")]
        public async void insertInCarrinho(CarrinhoModel carrinho)
        {
            carrinho.quantidade = 1;
            await context.Carrinho.AddAsync(carrinho);
            await context.SaveChangesAsync();
        }
        [HttpGet("carrinho/{id_cliente}")]
        public async Task<IActionResult> getCarrinho(int id_cliente)
        {
            var lista_itens = await (
                from carrinho in context.Carrinho
                join livros in context.Livros
                on carrinho.id_livro equals livros.livro_id
                where carrinho.id_cliente == id_cliente
                select new
                {
                    livros.livro_id,
                    livros.nome_livro,
                    livros.url_img_livro,
                    livros.preco,
                    carrinho.quantidade
                }).ToListAsync();
            return Ok(lista_itens);
        }
        [HttpDelete("carrinho/del/{id_cliente}&&{id_livro}")]
        public async void delProd(int id_cliente, int id_livro)
        {
            var carrinho = await context.Carrinho.Where(carrin => carrin.id_cliente == id_cliente && carrin.id_livro == id_livro).FirstOrDefaultAsync();
            context.Carrinho.Remove(carrinho);
            await context.SaveChangesAsync();
        }
    }
}
