using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_api.Dominio.Entidades
{
    /// <summary>
    /// Clase que representa la entidad Alumno
    /// </summary>
    public class Alumno : Auditoria
    {
        /// <summary>
        /// Nombres
        /// </summary>
        public string Nombres { get; private set; }
        /// <summary>
        /// Apellidos
        /// </summary>
        public string Apellidos { get; private set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Tipo de documento
        /// </summary>
        public string TipoDocumento { get; private set; }
        /// <summary>
        /// Numero de documento
        /// </summary>
        public string NumeroDocumento { get; private set; }
        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime FechaNacimiento { get; private set; }
        /// <summary>
        /// Sexo
        /// </summary>
        public bool Sexo { get; private set; }
        /// <summary>
        /// Numero de telefono
        /// </summary>
        public string? Telefono { get; private set; }
        /// <summary>
        /// Nacionalidad
        /// </summary>
        public string Nacionalidad { get; private set; }
        /// <summary>
        /// Imagen
        /// </summary>
        public byte[] Imagen { get; private set; }

        /// <summary>
        /// Metodo para crear la entidad Alumno
        /// </summary>
        /// <param name="nombres">Nombres</param>
        /// <param name="apellidos">Apellidos</param>
        /// <param name="email">Email</param>
        /// <param name="tipoDocumento">Tipo de documento</param>
        /// <param name="numeroDocumento">Numero de documento</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento</param>
        /// <param name="sexo">Sexo</param>
        /// <param name="telefono">Telefono</param>
        /// <param name="nacionalidad">Nacionalidad</param>
        /// <returns>Alumno</returns>
        public static Alumno Crear(string nombres, string apellidos, string email,
            string tipoDocumento, string numeroDocumento, DateTime fechaNacimiento, bool sexo,
            string? telefono, string nacionalidad, byte[] imagen)
        {
            return new Alumno
            {
                Nombres = nombres,
                Apellidos = apellidos,
                Email = email,
                TipoDocumento = tipoDocumento,
                NumeroDocumento = numeroDocumento,
                FechaNacimiento = fechaNacimiento,
                Sexo = sexo,
                Telefono = telefono,
                Nacionalidad = nacionalidad,
                Imagen = imagen,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        /// <summary>
        /// Metodo para modificar la entidad
        /// </summary>
        /// <param name="imagen">Imagen</param>
        public void Modificar(byte[] imagen)
        {
            Imagen = imagen;
            FechaModificacion = DateTime.Now;
        }
    }
}
