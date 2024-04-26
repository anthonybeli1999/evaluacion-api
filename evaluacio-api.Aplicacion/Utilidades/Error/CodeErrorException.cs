using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Utilidades.Error
{
    public class CodeErrorException : CodeErrorResponse
    {
        public string? CodigoError { get; }
        public Dictionary<string, string[]> Errores { get; }

        public CodeErrorException(string codigoError = null,
            string? mensaje = null)
        {
            CodigoError = codigoError;
            Mensaje = mensaje;
        }

        public CodeErrorException(int statusCode,
            string? mensaje = null,
            string? codigoError = null,
            Dictionary<string, string[]>? errores = null)
            : base(statusCode, mensaje)
        {
            CodigoError = codigoError;
            Mensaje = mensaje;
            Errores = errores;
        }
    }
}
