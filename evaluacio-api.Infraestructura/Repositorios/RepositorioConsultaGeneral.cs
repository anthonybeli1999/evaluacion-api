using evaluacio_api.Aplicacion.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura.Repositorios
{
    public class RepositorioConsultaGeneral : IRepositorioOperacionGeneral
    {
        public Task<T> AdicionarAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync<T>(T aoObjeto) where T : class
        {
            throw new NotImplementedException();
        }

        public void GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Listar<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> ModificarAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IList<T> ObtenerPorExpresionConLimite<T>(Expression<Func<T, bool>> ao_filtro = null, string as_incluir = null, byte aby_limite = 0) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
