using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IClienteRepository
    {

        /*metodo para devolver 1 cliente*/
        Task<Cliente> GetPorIdentidadAsync(string identidad);

        /*Crear un nuevo clienre*/
        Task<bool> NuevoAsync(Cliente cliente);

        /*Actualizar un cliente*/
        Task<bool> ActualizarAsync(Cliente cliente );

        /*eliminar un cliente*/
        Task<bool> EliminarAsync(string identidad);

        /*lista de cliente*/
        Task<IEnumerable<Cliente>> GetListaAsync();
    }
}
