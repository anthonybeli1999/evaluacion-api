using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Dto.AlumnoDto
{
    /// <summary>
    /// Clase DTO para entidad Alumno
    /// </summary>
    public class DtoAlumno
    {
        /// <summary>
        /// Nombres
        /// </summary>
        public string Nombres { get; set; }
        /// <summary>
        /// Apellidos
        /// </summary>
        public string Apellidos { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Tipo de documento
        /// </summary>
        public string TipoDocumento { get; set; }
        /// <summary>
        /// Numero de documento
        /// </summary>
        public string NumeroDocumento { get; set; }
        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// Sexo
        /// </summary>
        public bool Sexo { get; set; }
        /// <summary>
        /// Numero de telefono
        /// </summary>
        public string? Telefono { get; set; }
        /// <summary>
        /// Nacionalidad
        /// </summary>
        public string Nacionalidad { get; set; }
        /// <summary>
        /// Imagen
        /// </summary>
        public string Imagen { get; set; }
    }
}
