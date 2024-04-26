using evaluacio_api.Aplicacion.Dto.AlumnoDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Queries.ObtenerAlumhos
{
    public class ObtenerAlumnosQuery : IRequest<IEnumerable<DtoAlumno>>
    {
    }
}
