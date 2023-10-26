using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        [Required(ErrorMessage = "El código es obligatorio")]
        public string Codigo { get; set; } = string.Empty;
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        public string? Correo { get; set; }
        public string? Calve { get; set; }
        public byte[]? Foto { get; set; }
        public string Rol { get; set; } = string.Empty;
        public bool EstadoActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, string? correo, string? calve, byte[]? foto, string rol, bool estadoActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Correo = correo;
            Calve = calve;
            Foto = foto;
            Rol = rol;
            EstadoActivo = estadoActivo;
        }
    }
}
