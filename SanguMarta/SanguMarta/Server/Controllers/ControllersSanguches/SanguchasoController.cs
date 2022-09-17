using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sanguche.Data;
using Sanguche.Data.Entidades;
using Sanguches.Data.Entidades;

namespace SanguMarta.Server.Controllers.ControllersSanguches
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class SanguchasoController : ControllerBase
    {
        private readonly BDContext context;
                   
        public SanguchasoController(BDContext context)
        {
                this.context = context;
        }
        #region Controlador GET
        /// Nuevo-.-
        /// GET .- Te tira todo lo de la LISTA.
        [HttpGet]
        public async Task<ActionResult<List<Sanguchaso>>> Get() ///Llamo a la BDD sanguchasos
        {
            return await context.sanguchasos.ToListAsync(); ///Me devuelta lo que hay en la tabla "sanguchaso"
        }

        [HttpGet("{id:int}")]
        ///Llamo a ver si existe dicho sanguche, sino, me retorna el mensaje que no fue encontrado. Pero si existe, me devuelve el sangucheSabrosito
        public async Task<ActionResult<Sanguchaso>> Get(int Id)
        {
            Sanguchaso SanguchitoSabroso = await context.sanguchasos.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (SanguchitoSabroso == null)
            {
                return NotFound($"No existe el sanguche con dicho Id {Id}.");
            }
            return SanguchitoSabroso;
        }
        #endregion

        #region Controlador POST
        ///Con el POST, lo que hago es añadir más Sanguchitos sabrositos :3
        [HttpPost("{id:int}")]

        public async Task<ActionResult<Sanguchaso>> PostAsync(Sanguchaso SanguchitoSabroso)
        {
            try
            {
                context.sanguchasos.Add(SanguchitoSabroso); ///Añado
                await context.SaveChangesAsync(); ///Guardo
                return SanguchitoSabroso; ///Me devuelve Sanguchitos
            }
            catch (Exception e)
            {
                return BadRequest(e.Message); ///Por si por algún casual no pude añadir sanguchitos.
            }
        }
        #endregion

        #region Controlador PUT
        /// Con el controlador PUT lo que hago es modificar datos de la ENTIDAD de la cual este dirigo dicho controller, en este caso, de la clase Sanguchaso.
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Sanguchaso Sandw) ///Busca desde el query, la bdd, dicha información. "Sand" es el NUEVO OBJETO que reemplazaría a "SanguchitoSabroso"
        {
            Sanguchaso SanguchitoSabroso = await context.sanguchasos.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (SanguchitoSabroso == null)
            {
                return NotFound("No Existe el Sanguche a Modificar."); ///Si no lo encuentra, devuelve dicho mensaje.
            }
            ///Pero si lo encuentra, "Sand" es el NUEVO OBJETO que reemplazaría a "SanguchitoSabroso"
            SanguchitoSabroso.MontoXDocena = Sandw.MontoXDocena;
            SanguchitoSabroso.TipoSanguche = Sandw.TipoSanguche;
            SanguchitoSabroso.codigo = Sandw.codigo;
            
            try
            {
                context.sanguchasos.Remove(SanguchitoSabroso); /// Borra a SanguchitoSabroso...
                await context.SaveChangesAsync(); ///Guarda los cambios...
                return Ok("Los Datos Fueron Modificados."); ///Y me avisa que se han modificado.
            }
            catch (Exception e)
            {
                return BadRequest(e.Message); ///Esto saltaría si el cambio resultó como error.
            }
        }
        #endregion

        #region Controlador DELETE
        ///Con el controlador DELETE lo que hago es básicamente como su nombre en inglés indica, BORRAR.
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("No es correcto");
            }
            Sanguchaso SanguchitoSabroso = await context.sanguchasos.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (SanguchitoSabroso == null) ///Parametro que no puede ser nulo el dato.
            {
                return NotFound($"No existe el Sanguche con id igual a {id}.");/// Devuleve un ERROR.
            }

            try
            {
                context.sanguchasos.Remove(SanguchitoSabroso);
                await context.SaveChangesAsync();
                return Ok($"El Sanguche {SanguchitoSabroso.TipoSanguche} ha sido B O R R A D O ! !.");/// Devuelve que ha sido borrado.
            }
            catch (Exception) /// Se Captura la Excepcion del try
            {
                return new StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError);
            }

        }
        #endregion

    }

}
