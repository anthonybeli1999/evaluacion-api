using evaluacio_api.Infraestructura;
using evaluacio_api.Aplicacion;
using Microsoft.OpenApi.Models;
using evaluacion_api.Authentication;
using Serilog;

try
{
    var builder = WebApplication.CreateBuilder(args);

    #region services

    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.FromLogContext()
        .CreateLogger();
    builder.Logging.ClearProviders();
    builder.Logging.AddSerilog(Log.Logger);

    builder.Services.AddControllersWithViews();
    builder.Services.AddSignalR();
    builder.Services.AddControllers(options =>
    {
        options.EnableEndpointRouting = false;
    });


    builder.Services.AddSwaggerGen(s =>
    {
        s.SwaggerDoc("v1", new OpenApiInfo { Title = "evaluacion-api", Version = "v1" });
    });

    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("CORSPolicy",
            builder => builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowAnyOrigin());
    });

    builder.Services.AddConfigurationInfraestructura();
    builder.Services.AddConfigurationAplicacion();


    #endregion services

    #region configuration
    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    else
    {
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseAuthorization();

    app.UseCors("CORSPolicy");

    app.UseMiddleware(typeof(ApiKeyMiddleware), "evaluacion-api-pass");

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    app.Run();

    #endregion configuracion
}
catch (Exception ex)
{

}
finally
{

}