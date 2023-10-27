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
    public class ClienteRepository : IClienteRepository
    {
        private string _cadenaConexion;

        public ClienteRepository(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(_cadenaConexion);
        }
        
        /*Metodos*/
        public async Task<bool> ActualizarAsync(Cliente cliente)
        {
            bool salida = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE cliente SET Nombre = @Nombre, Direccion = @Direccion, ");
                sql.Append(" FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Correo = @Correo, Foto = @Foto, EstadoActivo = @EstadoActivo ");
                sql.Append(" WHERE Identidad = @Identidad; ");

                salida = Convert.ToBoolean(await _conexion.ExecuteAsync(sql.ToString(), cliente));

            }
            catch (Exception)
            {

            }
            return salida;
        }

        public async Task<bool> EliminarAsync(string identidad)
        {
            bool salida = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                string sql = "DELETE FROM cliente WHERE Identidad = @Identidad;";

                salida = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, new { identidad }));

            }
            catch (Exception)
            {

            }
            return salida;
        }

        public async Task<IEnumerable<Cliente>> GetListaAsync()
        {
            IEnumerable<Cliente> salida = new List<Cliente>();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM cliente;";
                salida = await _conexion.QueryAsync<Cliente>(sql);

            }
            catch (Exception)
            {

            }
            return salida;
        }

        public async Task<Cliente> GetPorIdentidadAsync(string identidad)
        {
            Cliente salida = new Cliente();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM cliente WHERE Identidad = @Identidad;";
                salida = await _conexion.QueryFirstAsync<Cliente>(sql, new { identidad });
            }
            catch (Exception)
            {

            }
            return salida;
        }

        public async Task<bool> NuevoAsync(Cliente cliente)
        {
            bool salida = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO cliente (Nombre, Direccion, FechaNacimiento, Telefono, Correo, Foto, EstadoActivo) ");
                sql.Append(" VALUES (@Nombre, @Direccion, @FechaNacimiento, @Telefono, @Correo, @Foto, @EstadoActivo) ");

                salida = Convert.ToBoolean(await _conexion.ExecuteAsync(sql.ToString(), cliente));

            }
            catch (Exception)
            {

            }
            return salida;
        }

    
    }
}
