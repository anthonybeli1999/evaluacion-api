using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace evaluacio_api.Aplicacion
{
    public static class ConfiguracionSimpleInjector
    {
        public static IServiceCollection AddConfigurationAplicacion(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
