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
    public class FacturaRepository : IFacturaRepository
    {

        private string _cadenaConexion;

        public FacturaRepository(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(_cadenaConexion);
        }

        /*metodos*/
        public async Task<string> Nueva(Factura factura)
        {
            string salida = string.Empty;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO factura (Codigo, Fecha, IdentidadCliente, CodigoUsuario, CodigoEstado, Subtotal, ISV, Descuento, Total) ");
                sql.Append(" VALUES (@Codigo, @Fecha, @IdentidadCliente, @CodigoUsuario, @CodigoEstado, @Subtotal, @ISV, @Descuento, @Total) ");
                sql.Append(" SELECT LAS_INSERT_ID() ");
               salida = Convert.ToString(await _conexion.ExecuteScalarAsync(sql.ToString(), factura));

            }
            catch (Exception)
            {

            }
            return salida;
        }
    }
}
