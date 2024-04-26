using evaluacio_api.Aplicacion.Repositorios;
using evaluacio_api.Infraestructura.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura.Repositorios
{
    public class RepositorioOperacionGeneral : IRepositorioOperacionGeneral
    {
        protected readonly ContextoGeneral _contextoConsultas;

        public RepositorioOperacionGeneral(ContextoGeneral contextoConsultas)
        {
            _contextoConsultas = contextoConsultas;
        }

        public async Task<T> AdicionarAsync<T>(T entity) where T : class
        {
            try
            {
                _contextoConsultas
                .Set<T>()
                .Add(entity);
                return entity;
            }
            catch (Exception le_excepcion)
            {
                throw new Exception( "Error BD: " + le_excepcion);
            }
        }

        public async Task EliminarAsync<T>(T aoObjeto) where T : class
        {
            _contextoConsultas
                .Set<T>()
                .Remove(aoObjeto);
            await _contextoConsultas
                .SaveChangesAsync();
        }

        public void GuardarCambios()
        {
            try
            {
                _contextoConsultas.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Error al guardar cambios en la base de datos" + e.Message);
            }
        }

        public IQueryable<T> Listar<T>() where T : class
        {
            return _contextoConsultas
                .Establecer<T>();
        }

        public async Task<T> ModificarAsync<T>(T entity) where T : class
        {
            _contextoConsultas.Entry(entity).State = EntityState.Modified;
            await _contextoConsultas
                .SaveChangesAsync();
            return entity;
        }

        public IList<T> ObtenerPorExpresionConLimite<T>(Expression<Func<T, bool>> ao_filtro = null,
            string as_incluir = null,
            byte aby_limite = 0) where T : class
        {
            try
            {
                if (ao_filtro != null)
                {
                    if (aby_limite == 0)
                        return _contextoConsultas.Establecer<T>().Where(ao_filtro).ToList();
                    else
                        return _contextoConsultas.Establecer<T>().Where(ao_filtro).Take(aby_limite).ToList();
                }
                else
                {
                    return _contextoConsultas.Establecer<T>().ToList();
                }
            }
            catch (Exception le_excepcion)
            {
                throw new Exception( "Error BD: " + le_excepcion);
            }
        }
    }
}
