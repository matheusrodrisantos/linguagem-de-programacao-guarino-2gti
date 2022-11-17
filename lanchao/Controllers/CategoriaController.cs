
using Microsoft.AspNetCore.Mvc;
using Lanchao.Model;
using Lanchao.Data;
using Microsoft.EntityFrameworkCore;
namespace Lanchao.Controllers;

[ApiController]
[Route("categorias")]
public class CategoriaController : Controller{

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult<Categoria>> PostAsync([FromServices] DataContext context, [FromBody] Categoria model)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        context.Categorias.Add(model);
        await context.SaveChangesAsync();
        return model;
    }
}

