using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IFacturaRepository
    {
        /*Metodo para crear una nueva factura*/
        Task<string> Nueva(Factura factura);

    }
}
