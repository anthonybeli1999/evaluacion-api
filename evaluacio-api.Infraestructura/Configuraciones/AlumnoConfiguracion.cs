using evaluacion_api.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura.Configuraciones
{
    public class AlumnoConfiguracion : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.ToTable("Alumno");
            builder.HasKey(c => new { c.NumeroDocumento });

            builder.Property(m => m.Nombres).HasColumnName("Nombres");
            builder.Property(m => m.Apellidos).HasColumnName("Apellidos");
            builder.Property(m => m.Email).HasColumnName("Email");
            builder.Property(m => m.TipoDocumento).HasColumnName("TipoDocumento");
            builder.Property(m => m.NumeroDocumento).HasColumnName("NumeroDocumento");
            builder.Property(m => m.FechaNacimiento).HasColumnName("FechaNacimiento");
            builder.Property(m => m.Sexo).HasColumnName("Sexo");
            builder.Property(m => m.Telefono).HasColumnName("Telefono");
            builder.Property(m => m.Nacionalidad).HasColumnName("Nacionalidad");
            builder.Property(m => m.Imagen).HasColumnName("Imagen");
            builder.Property(m => m.FechaCreacion).HasColumnName("FechaCreacion");
            builder.Property(m => m.FechaModificacion).HasColumnName("FechaModificacion");
        }
    }
}
