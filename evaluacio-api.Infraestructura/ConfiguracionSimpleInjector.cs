using evaluacio_api.Aplicacion.Repositorios;
using evaluacio_api.Infraestructura.Contextos;
using evaluacio_api.Infraestructura.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura
{
    public static class ConfiguracionSimpleInjector
    {
        public static IServiceCollection AddConfigurationInfraestructura(this IServiceCollection services)
        {
            services.AddDbContext<ContextoGeneral>();
            services.AddScoped<IRepositorioOperacionGeneral, RepositorioOperacionGeneral>();
            return services;
        }
    }
}
