using evaluacio_api.Infraestructura.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura.Contextos
{
    public class ContextoBase<TContexto> : DbContext, IContextoBase where TContexto : class
    {

        public ContextoBase(DbContextOptions<ContextoGeneral> options) : base(options)
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ObtenerCadenaConexion()).UseLazyLoadingProxies();
        }

        private static string ObtenerCadenaConexion()
        {
            string servidor = "DESKTOP-EET30CO\\SQLEXPRESS";
            string catalogo = "evaluacion";

            var datosConexion = new SqlConnectionStringBuilder
            {
                DataSource = servidor,
                InitialCatalog = catalogo,
                IntegratedSecurity = true,
                TrustServerCertificate = true,
                ApplicationName = "evaluacion-api"
            };
            return datosConexion.ConnectionString;
        }
        public DbSet<T> Establecer<T>() where T : class
        {
            return Set<T>();
        }

        public void GuardarCambios()
        {
            try
            {
                SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entidadesInvolucradas = ex.Entries.Aggregate(string.Empty,
                    (current, entidad) => current + (entidad.Entity.GetType() + ","));

                throw new Exception("Error al guardar cambios en la base de datos.", ex);
            }
            catch (DbUpdateException ex)
            {
                var mensaje = ex.Entries.Aggregate(string.Empty,
                    (current, entidad) => current + ("Entidad de tipo " + entidad.Entity.GetType().Name +
                                                     " en estado " + entidad.State +
                                                     " tiene los siguientes errores de validación: "));
                throw new Exception("Error al guardar cambios en la base de datos. " + mensaje, ex);
            }
        }
    }
}
