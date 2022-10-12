using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sanguche.Data;
using Sanguche.Data.Entidades;

namespace SanguMarta.Server.Controllers.ControllersSanguches
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class PedidoVentaController: ControllerBase
    {
        private readonly BDContext context;
        public PedidoVentaController(BDContext context)
        {
            this.context = context;
        }
        #region Controlador GET
        /// Nuevo-.-
        /// GET .- Te tira todo lo de la LISTA.
        [HttpGet]
        public async Task<ActionResult<List<PedidoVenta>>> Get() ///Llamo a la BDD PedidoVenta
        {
            return await context.tiposdeSanguchasos.ToListAsync(); ///Me devuelta lo que hay en la tabla "tiposdeSanguchasos"
        }

        [HttpGet("{id:int}")]
        ///Llamo a ver si existe dicho Tiposanguche, sino, me retorna el mensaje que no fue encontrado. Pero si existe, me devuelve el sangucheSabrosito
        public async Task<ActionResult<PedidoVenta>> Get(int Id)
        {
            PedidoVenta PedidoYVenta = await context.tiposdeSanguchasos.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (PedidoYVenta == null)
            {
                return NotFound($"No existe el sanguche con dicho Id {Id}.");
            }
            return PedidoYVenta;
        }
        #endregion

        #region CONTROLADOR POST
        ///Con el POST, lo que hago es añadir más Sanguchitos sabrositos :3
        [HttpPost("{id:int}")]

        public async Task<ActionResult<PedidoVenta>> PostAsync(PedidoVenta PedidoYVenta)
        {
            try
            {
                context.tiposdeSanguchasos.Add(PedidoYVenta); ///Añado
                await context.SaveChangesAsync(); ///Guardo
                return PedidoYVenta; ///Me devuelve Sanguchitos
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
        public async Task<ActionResult> Put(int id, [FromBody] PedidoVenta Sandw) ///Busca desde el query, la bdd, dicha información. "Sand" es el NUEVO OBJETO que reemplazaría a "PedidoYVenta"
        {
            PedidoVenta PedidoYVenta = await context.tiposdeSanguchasos.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (PedidoYVenta == null)
            {
                return NotFound("No Existe el Sanguche a Modificar."); ///Si no lo encuentra, devuelve dicho mensaje.
            }
            ///Pero si lo encuentra, "Sand" es el NUEVO OBJETO que reemplazaría a "SanguchitoSabroso"
            PedidoYVenta.CodigoPedido = Sandw.CodigoPedido;
            PedidoYVenta.Domicilio = Sandw.Domicilio;
            PedidoYVenta.Fecha = Sandw.Fecha;
            PedidoYVenta.Horario = Sandw.Horario;
            PedidoYVenta.NombreCliente = Sandw.NombreCliente;


            try
            {
                context.tiposdeSanguchasos.Remove(PedidoYVenta); /// Borra a PedidoYVenta...
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
            PedidoVenta PedidoYVenta = await context.tiposdeSanguchasos.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (PedidoYVenta == null) ///Parametro que no puede ser nulo el dato.
            {
                return NotFound($"No existe el Sanguche con id igual a {id}.");/// Devuleve un ERROR.
            }

            try
            {
                context.tiposdeSanguchasos.Remove(PedidoYVenta);
                await context.SaveChangesAsync();
                return Ok($"El Pedido {PedidoYVenta.CodigoPedido} ha sido B O R R A D O ! !.");/// Devuelve que ha sido borrado.
            }
            catch (Exception) /// Se Captura la Excepcion del try
            {
                return new StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError);
            }
            ///All we need is just test it. if it works, i will be the happiest man in the entire world.
        }
        #endregion
    }
}
