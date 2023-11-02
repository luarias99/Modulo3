using Dapper;
using Datos.Interfaces;
using Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class DetalleFacturaRepository : IDetalleFacturaRepository
    {
        private string _cadenaConexion;

        public DetalleFacturaRepository(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(_cadenaConexion);
        }
        
        /*Metodos*/
        public async Task<bool> Nuevo(DetalleFactura detalleFactura)
        {
            bool salida = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                string sql = @"INSERT INTO detallefactura (CodigoFactura, CodigoProducto, Cantidad, Precio, Total ) 
                                VALUES (@CodigoFactura, @CodigoProducto, @Cantidad, @Precio, @Total ) ;";
                salida = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, detalleFactura));

            }
            catch (Exception)
            {

            }
            return salida;
        }
    }
}
