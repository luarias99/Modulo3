using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IEstadoFacturaRepository
    {
        /*metodo para devolver 1 estado*/
        Task<EstadoFactura> GetPorCodigoAsync(string codigo);

        /*Crear un nuevo estado*/
        Task<bool> NuevoAsync(EstadoFactura estadoFactura);

        /*Actualizar un estado*/
        Task<bool> ActualizarAsync(EstadoFactura estadoFactura);

        /*eliminar un estado*/
        Task<bool> EliminarAsync(string codigo);

        /*lista de estado*/
        Task<IEnumerable<EstadoFactura>> GetListaAsync();
    }
}
