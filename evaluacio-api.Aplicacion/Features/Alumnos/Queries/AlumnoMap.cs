using evaluacio_api.Aplicacion.Dto.AlumnoDto;
using evaluacion_api.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Features.Alumnos.Queries
{
    public static class AlumnoMap
    {
        public static DtoAlumno MapearEntidadADto(Alumno alumno)
        {
            return new DtoAlumno
            {
                Nombres = alumno.Nombres,
                Apellidos = alumno.Apellidos,
                Email = alumno.Email,
                TipoDocumento = alumno.TipoDocumento,
                NumeroDocumento = alumno.NumeroDocumento,
                FechaNacimiento = alumno.FechaNacimiento,
                Sexo = alumno.Sexo,
                Telefono = alumno.Telefono,
                Nacionalidad = alumno.Nacionalidad,
                Imagen = Convert.ToBase64String(alumno.Imagen)
            };
        }
    }
}
