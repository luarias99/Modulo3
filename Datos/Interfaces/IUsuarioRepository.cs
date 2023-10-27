using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IUsuarioRepository
    {
        /*metodo para devolver 1 usuario*/
        Task<Usuario> GetPorCodigoAsync(string codigo);

        /*Crear un nuevo usuario*/
        Task<bool> NuevoAsync(Usuario usuario);

        /*Actualizar un usuario*/
        Task<bool> ActualizarAsync(Usuario usuario);

        /*eliminar un usuario*/
        Task<bool> EliminarAsync(string codigo);

        /*lista de usuarios*/
        Task<IEnumerable<Usuario>> GetListaAsync();




    }
}
