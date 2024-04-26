using evaluacio_api.Infraestructura.Configuraciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura.Contextos
{
    public class ContextoGeneral : ContextoBase<ContextoGeneral>
    {
        public ContextoGeneral(DbContextOptions<ContextoGeneral> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlumnoConfiguracion());
        }
    }
}
