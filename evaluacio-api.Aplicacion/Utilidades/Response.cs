using evaluacio_api.Aplicacion.Utilidades.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Utilidades
{
    public class Response<T>
    {
        public bool Resultado { get; set; }
        public string CodigoError { get; set; }
        public int StatusCode { get; set; }
        public object? Datos { get; set; }
        public CodeErrorException Errores { get; set; }

        public Response()
        {
        }

        public Response(object? dato)
        {
            this.Resultado = true;
            this.Datos = dato ?? string.Empty;
        }
        public Response(string codigoError, int statusCode,
            CodeErrorException errores)
        {
            this.Resultado = false;
            this.CodigoError = codigoError;
            this.StatusCode = statusCode;
            this.Errores = errores;
        }
    }
}
