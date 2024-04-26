using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Commands.ModificarAlumno
{
    public class ModificarAlumnoCommand : IRequest<string>
    {
        public string NumeroDocumento { get; set; }
        public string Imagen { get; set; }
    }
}
