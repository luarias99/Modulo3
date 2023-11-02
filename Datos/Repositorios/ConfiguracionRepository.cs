using Datos.Interfaces;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ConfiguracionRepository : IConfiguracionRepository
    {
        private string _cadenaConexion;

        public ConfiguracionRepository(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(_cadenaConexion);
        }


        /*Metodos*/
        public Task<bool> ActualizarAsync(Configuracion configuracion)
        {
            throw new NotImplementedException();
        }

        public Task<Configuracion> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarAsync(Configuracion configuracion)
        {
            throw new NotImplementedException();
        }
    }
}
