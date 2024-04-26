using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacio_api.Infraestructura.Interfaces
{
    public interface IContextoBase
    {
        DbSet<T> Establecer<T>() where T : class;
        void GuardarCambios();
    }
}
