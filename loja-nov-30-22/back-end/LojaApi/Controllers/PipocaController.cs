using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using LojaApi.Models;
using LojaApi.Data;

namespace LojaApi.Controllers{

    [ApiController]
    [Route("pipocas")]
    public class PipocaController: Controller{

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Pipoca>> Post([FromServices] DataContext context, [FromBody] Pipoca body){
            if (!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            var pipoca = new Pipoca(){
                Nome = body.Nome,
                DataCadastro = body.DataCadastro,
                Departamento = body.Departamento,
                Apelido=body.Apelido              
            };

            context.Pipocas.Add(pipoca);
            await context.SaveChangesAsync();

            return body;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pipoca>>> Listar([FromServices] DataContext context){
            var pipocas = await context.Pipocas.ToListAsync();
            return pipocas;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Pipoca>> Delete([FromServices] DataContext context, int id)
        {
            var pipoca = await context.Pipocas.FirstOrDefaultAsync(pipoca => pipoca.Id == id);
            if (pipoca != null)
            {
                context.Pipocas.Remove(pipoca);
                await context.SaveChangesAsync();

                return Ok(pipoca);
            }

            return NotFound();
        }
    }
}