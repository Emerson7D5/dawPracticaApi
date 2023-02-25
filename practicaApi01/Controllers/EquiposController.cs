using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaApi01.Models;

namespace practicaApi01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly equiposContext _equiposContext;

        public EquiposController(equiposContext equiposContext)
        {
            _equiposContext = equiposContext;
        }


        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            var listadoEquipo = (from e in _equiposContext.equipos
                                 select e).ToList();

            if (listadoEquipo.Count()==0)
                return NotFound();
            return Ok(listadoEquipo);

        }
    }
}
