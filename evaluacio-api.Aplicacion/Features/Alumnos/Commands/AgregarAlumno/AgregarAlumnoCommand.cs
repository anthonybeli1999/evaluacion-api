using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Commands.AgregarAlumno
{
    public class AgregarAlumnoCommand : IRequest<string>
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
        public string? Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public string Imagen { get; set; }
    }
}
