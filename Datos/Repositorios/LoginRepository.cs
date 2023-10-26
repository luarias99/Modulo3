using Dapper;
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
    public class LoginRepository : ILogionRepository
    {
        private string _cadenaConexion;

        public LoginRepository (string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }


        private MySqlConnection Conexion() 
        { 
            return new MySqlConnection (_cadenaConexion);
        }    


        /*Metodo para validar usuario*/
        public async Task<bool> ValidarUsuarioAsync(Login login)
        {
            bool salida = false;
            try

            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT 1 FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";
                salida = await _conexion.ExecuteScalarAsync<bool>(sql);
            }
            catch (Exception)
            {

            }
            return salida;

        }
    }
}
