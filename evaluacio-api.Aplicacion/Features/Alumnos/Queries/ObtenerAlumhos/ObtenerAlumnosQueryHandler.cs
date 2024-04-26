using evaluacio_api.Aplicacion.Dto.AlumnoDto;
using evaluacio_api.Aplicacion.Repositorios;
using evaluacion_api.Dominio.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Queries.ObtenerAlumhos
{
    public class ObtenerAlumnosQueryHandler : IRequestHandler<ObtenerAlumnosQuery,
        IEnumerable<DtoAlumno>>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ObtenerAlumnosQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<IEnumerable<DtoAlumno>> Handle(ObtenerAlumnosQuery request, CancellationToken cancellationToken)
        {
            var alumnos = _repositorioOperacionGeneral
                .Listar<Alumno>().ToList();
            return alumnos
                .ConvertAll(a => AlumnoMap.MapearEntidadADto(a));
        }
    }
}
