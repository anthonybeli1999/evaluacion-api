using evaluacio_api.Aplicacion.Features.Alumnos.Commands.ModificarAlumno;
using evaluacio_api.Aplicacion.Repositorios;
using evaluacion_api.Dominio.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Commands.ModificarAlumno
{
    public class ModificarAlumnoCommandHandler : IRequestHandler<ModificarAlumnoCommand, string>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarAlumnoCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<string> Handle(ModificarAlumnoCommand request, CancellationToken cancellationToken)
        {
            byte[] imagenBytes = Convert.FromBase64String(request.Imagen.Split(",")[1]);
            var alumno = _repositorioOperacionGeneral
                .ObtenerPorExpresionConLimite<Alumno>(a => a.NumeroDocumento == request.NumeroDocumento).First();
            alumno.Modificar(imagenBytes);
            _repositorioOperacionGeneral.GuardarCambios();
            return alumno.NumeroDocumento;
        }
    }
}
