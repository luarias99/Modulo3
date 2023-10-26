using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        [Required(ErrorMessage ="El código es obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "La identidad cliente es obligatorio")]
        public string IdentidadCliente { get; set;} = string.Empty;
        [Required(ErrorMessage = "El código Usuario es obligatorio")]
        public string CodigoUsuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "El código Estado es obligatorio")]
        public string CodigoEstado { get; set; } = string.Empty;
        public decimal Subtotal { get; set; }
        public decimal ISV { get; set; } 
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
        }

        public Factura(string codigo, DateTime fecha, string identidadCliente, string codigoUsuario, string codigoEstado, decimal subtotal, decimal iSV, decimal descuento, decimal total)
        {
            Codigo = codigo;
            Fecha = fecha;
            IdentidadCliente = identidadCliente;
            CodigoUsuario = codigoUsuario;
            CodigoEstado = codigoEstado;
            Subtotal = subtotal;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
        }
    }
}
