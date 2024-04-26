using evaluacio_api.Aplicacion.Repositorios;
using evaluacion_api.Dominio.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Commands.AgregarAlumno
{
    public class AgregarAlumnoCommandHandler : IRequestHandler<AgregarAlumnoCommand, string>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public AgregarAlumnoCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            :base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<string> Handle(AgregarAlumnoCommand request, CancellationToken cancellationToken)
        {
            byte[] imagenBytes = Convert.FromBase64String(request.Imagen.Split(",")[1]);

            var alumno = Alumno.Crear(request.Nombres, request.Apellidos, request.Email,
                request.TipoDocumento, request.NumeroDocumento, request.FechaNacimiento,
                request.Sexo, request.Telefono, request.Nacionalidad, imagenBytes);

            var nuevoAlumno = await _repositorioOperacionGeneral
                .AdicionarAsync(alumno);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoAlumno.NumeroDocumento;
        }
    }
}
