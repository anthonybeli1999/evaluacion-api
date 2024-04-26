using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Commands.EliminarAlumno
{
    public class EliminarAlumnoCommand : IRequest<string>
    {
        public string NumeroDocumento { get; set; }
    }
}
