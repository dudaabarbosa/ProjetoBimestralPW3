using API_ProjetoBimestral.Models;
using API_ProjetoBimestral.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ProjetoBimestral.Controllers
{
    [EnableCors("AllowSpecificOrigins")]
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
                                   livros.url_img_livro,
                                   livros.preco
                               }).ToListAsync();
            return Ok(livro);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> livroOneGet(int id)
        {
            var livro = await (from livros in context.Livros
                               where livros.livro_id == id
                               select new
                               {
                                   livros.livro_id,
                                   livros.nome_livro,
                                   livros.autor,
                                   livros.url_img_livro,
                                   livros.preco,
                                   livros.editora
                               }).SingleOrDefaultAsync();
            return Ok(livro);
        }

        [HttpPost]
        public async void livroPost(LivroModelPost new_livro)
        {
            var img = new_livro.img_livro.Split(',')[1];
            var img_icon = Convert.FromBase64String(img.Trim().Replace(" ", "").Replace("\n", ""));
            var livro = new LivroModel(
                new_livro.nome_livro,
                img_icon,
                new_livro.autor,
                new_livro.preco,
                new_livro.paginas,
                new_livro.editora,
                new_livro.publicacao);
            await context.Livros.AddAsync(livro);
            await context.SaveChangesAsync();
            var id = livro.livro_id; 
            livro.url_img_livro = "http://localhost:5071/api/livro/img/" + id;

            // Atualizando o registro com a URL da imagem
            context.Livros.Update(livro);
            await context.SaveChangesAsync();
        }

        [HttpPost("teste")]
        public async Task<IActionResult> imageeemGet([FromBody] int id)
        {
            if (id > 2)
            {
                return Ok(id);
            }
            else
            {
                return Ok(id);
            }
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

        [HttpPut("alter/{id}&&{autor}&{preco}&{editora}")]
        public async void putLivro(int id, string autor, float preco, string editora)
        {
            var livro = await context.Livros.FindAsync(id);
            livro.autor = autor;
            livro.preco = preco;
            livro.editora = editora;
            await context.SaveChangesAsync();
        }

        [HttpDelete("delete/{id}")]
        public async void deleteLivro(int id)
        {
            var livro = await context.Livros.FindAsync(id);
            context.Livros.Remove(livro);
            await context.SaveChangesAsync();
        }
    }
}
