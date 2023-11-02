using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IConfiguracionRepository
    {
        /*obtener la configuracion*/
        Task<Configuracion> GetAsync();
        Task<bool> GuardarAsync(Configuracion configuracion);
        Task<bool> ActualizarAsync(Configuracion configuracion);


    }
}
