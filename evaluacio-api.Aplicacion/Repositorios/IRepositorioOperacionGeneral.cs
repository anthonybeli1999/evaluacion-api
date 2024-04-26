using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Repositorios
{
    public interface IRepositorioOperacionGeneral : IRepositorioConsultaGeneral
    {
        Task<T> AdicionarAsync<T>(T entity) where T : class;
        Task<T> ModificarAsync<T>(T entity) where T : class;
        Task EliminarAsync<T>(T aoObjeto) where T : class;
        void GuardarCambios();
    }
}
