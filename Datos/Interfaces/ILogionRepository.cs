using Entidades;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface ILogionRepository
    {
        Task<bool> ValidarUsuarioAsync(Login login);
    }
}
