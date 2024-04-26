using evaluacio_api.Aplicacion.Features.Alumnos.Commands.ModificarAlumno;
using evaluacio_api.Aplicacion.Repositorios;
using evaluacion_api.Dominio.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Commands.EliminarAlumno
{
    public class EliminarAlumnoCommandHandler : IRequestHandler<EliminarAlumnoCommand, string>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public EliminarAlumnoCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<string> Handle(EliminarAlumnoCommand request, CancellationToken cancellationToken)
        {
            var alumno = _repositorioOperacionGeneral
                .ObtenerPorExpresionConLimite<Alumno>(a => a.NumeroDocumento == request.NumeroDocumento).First();
            await _repositorioOperacionGeneral.EliminarAsync(alumno);
            _repositorioOperacionGeneral.GuardarCambios();

            return alumno.NumeroDocumento;
        }
    }
}
