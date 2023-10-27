using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface ICategoriaRepository
    {
        /*metodo para devolver 1 categoria*/
        Task<Categoria> GetPorCodigoAsync(string codigo);

        /*Crear un nuevo categ*/
        Task<bool> NuevaAsync(Categoria categoria);

        /*Actualizar un categ*/
        Task<bool> ActualizarAsync(Categoria categoria);

        /*eliminar un categ*/
        Task<bool> EliminarAsync(string codigo);

        /*lista de categ*/
        Task<IEnumerable<Categoria>> GetListaAsync();
    }
}
