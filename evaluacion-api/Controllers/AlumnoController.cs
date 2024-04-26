using evaluacio_api.Aplicacion.Dto.AlumnoDto;
using evaluacio_api.Aplicacion.Features.Alumnos.Commands.AgregarAlumno;
using evaluacio_api.Aplicacion.Features.Alumnos.Commands.EliminarAlumno;
using evaluacio_api.Aplicacion.Features.Alumnos.Commands.ModificarAlumno;
using evaluacio_api.Aplicacion.Features.Alumnos.Queries.ObtenerAlumhos;
using evaluacion_api.Logger;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace evaluacion_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : BaseController<AlumnoController>
    {
        private readonly ILogger<AlumnoController> _logger;
        public AlumnoController(ILogger<AlumnoController> logger,
            IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<long>> RegistrarAlumno([FromBody] AgregarAlumnoCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<long>> ModificarAlumno([FromBody] ModificarAlumnoCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("Eliminar")]
        public async Task<ActionResult<long>> EliminarAlumno([FromBody] EliminarAlumnoCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(IEnumerable<DtoAlumno>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoAlumno>>> ObtenerAlumnos()
        {
            var comando = new ObtenerAlumnosQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
    }
}
