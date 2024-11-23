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
    }
}
