using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SIG.FCT.CORE.Aplicacion.Contratos.Servicios;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Servicios.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenesController : ControllerBase
    {
        private readonly IServicioOrden _Ordenes;

        public OrdenesController( IServicioOrden orderService )
        {
            _Ordenes = orderService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Orden>> Get()
        {
            return Ok(_Ordenes.ListarTodos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Orden> Get( int id )
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            return Ok(_Ordenes.BuscarPorId(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Orden> Post( [FromBody] Orden orden )
        {
            try
            {
                return Ok(_Ordenes.Crear(orden));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Orden> Put( int id, [FromBody] Orden orden )
        {
            if (id < 1 || id != orden.Id)
            {
                return BadRequest("Parameter Id and order ID must be the same");
            }

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Orden> Delete( int id )
        {
            var orden = _Ordenes.Eliminar(id);
            if (orden == null)
            {
                return StatusCode(404, "Did not find Customer with ID " + id);
            }
            return Ok($"Order with Id: {id} is Deleted");
        }
    }
}
