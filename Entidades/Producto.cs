using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        [Required(ErrorMessage = "El código es obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set;} = string.Empty;
        public decimal Precio { get; set;}
        public int Existencia { get; set;}
        public byte[]? Foto { get; set;}
        public DateTime FechaCreacion { get; set;}
        [Required(ErrorMessage = "El código categoria es obligatorio")]
        public string CodigoCategoria { get; set; } = string.Empty;
        [Required(ErrorMessage = "El código Usuario es obligatorio")]
        public string CodigoUsuario {  get; set; } = string.Empty;
        public decimal ISV { get; set;}
        public bool EstadoActivo { get; set;}

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, decimal precio, int existencia, byte[]? foto, DateTime fechaCreacion, string codigoCategoria, string codigoUsuario, decimal iSV, bool estadoActivo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
            Foto = foto;
            FechaCreacion = fechaCreacion;
            CodigoCategoria = codigoCategoria;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            EstadoActivo = estadoActivo;
        }
    }
}
