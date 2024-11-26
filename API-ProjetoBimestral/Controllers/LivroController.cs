using API_ProjetoBimestral.Models;
using API_ProjetoBimestral.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ProjetoBimestral.Controllers
{
    [Route("api/livro")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        ConnectionContextDB context = new ConnectionContextDB();
        [HttpGet]
        public async Task<IActionResult> livroGet()
        {
            var livro = await (from livros in context.Livros
                               select new
                               {
                                   livros.livro_id,
                                   livros.nome_livro,
                                   livros.autor,
                                   livros.url_img_livro
                               }).ToListAsync();
            return Ok(livro);
        }

        [HttpPost]
        public async void livroPost(LivroModelPost new_livro)
        {
            var img_icon = Convert.FromBase64String(new_livro.img_livro.Trim().Replace(" ", "").Replace("\n", ""));
            var id = await context.Livros.CountAsync() + 1;
            await context.Livros.AddAsync(new LivroModel(
                new_livro.nome_livro,
                img_icon,
                "http://localhost:5071/api/livro/img/" + id,
                new_livro.autor,
                new_livro.preco,
                new_livro.paginas,
                new_livro.editora,
                new_livro.publicacao));
            await context.SaveChangesAsync();
        }

        [HttpGet("img/{id}")]
        public async Task<IActionResult> imagemGet(int id)
        {
            byte[]? livro_image = (await context.Livros.FindAsync(id)).img_livro;
            if (livro_image == null)
            {
                return BadRequest();
            }
            return File(livro_image, "image/jpeg");
        }
    }
}
