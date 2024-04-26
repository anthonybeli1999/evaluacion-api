using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_api.Dominio
{
    /// <summary>
    /// Clase que representa datos de Auditoria
    /// </summary>
    public class Auditoria
    {
        /// <summary>
        /// Fecha de creacion
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Fecha de modificacion
        /// </summary>
        public DateTime FechaModificacion { get; set; }
    }
}
