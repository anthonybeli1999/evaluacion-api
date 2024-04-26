using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Utilidades.Error
{
    public class CodeErrorResponse
    {
        public int StatusCode { get; set; }
        public string? Mensaje { get; set; }

        public CodeErrorResponse()
        {
        }

        public CodeErrorResponse(int statusCode,
            string? mensaje = null)
        {
            StatusCode = statusCode;
            Mensaje = mensaje ?? GetDefaultMessageStatusCode(statusCode);
        }

        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "El request enviado tiene errores",
                401 => "No tienes autorizacion para este recurso",
                404 => "No se encontro el recurso solicitado",
                500 => "Se producieron errores en el servidor",
                _ => string.Empty,
            };
        }
    }
}
