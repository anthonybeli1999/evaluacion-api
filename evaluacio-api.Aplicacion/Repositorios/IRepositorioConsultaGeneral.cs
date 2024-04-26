using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Aplicacion.Repositorios
{
    public interface IRepositorioConsultaGeneral
    {
        IQueryable<T> Listar<T>() where T : class;
        
        IList<T> ObtenerPorExpresionConLimite<T>(Expression<Func<T, bool>> ao_filtro = null,
            string as_incluir = null,
            byte aby_limite = 0) where T : class;

    }
}
