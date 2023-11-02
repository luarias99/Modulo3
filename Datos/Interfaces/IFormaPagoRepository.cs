using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IFormaPagoRepository
    {
        /*metodo para devolver 1 formap*/
        Task<FormaPago> GetPorIdAsync(int id);

        /*Crear un nuevo formap*/
        Task<bool> NuevaAsync(FormaPago formaPago);

        /*Actualizar un formap*/
        Task<bool> ActualizarAsync(FormaPago formaPago);

        /*eliminar un formap*/
        Task<bool> EliminarAsync(int id);

        /*lista de formap*/
        Task<IEnumerable<FormaPago>> GetListaAsync();
    }
}
