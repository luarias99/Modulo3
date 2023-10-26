using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        [Required(ErrorMessage ="La identidad es obligatorio")]
        public string Identidad { get; set; } = string.Empty;
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set;} = string.Empty;
        public string? Direccion { get; set;}
        public DateOnly FechaNacimiento { get; set;}
        public string? Telefono { get; set;}
        public string? Correo { get; set;}
        public byte[]? Foto { get; set;}
        public bool EstadoActivo { get; set;}

        public Cliente() { }

        public Cliente(string identidad, string nombre, string? direccion, DateOnly fechaNacimiento, string? telefono, string? correo, byte[]? foto, bool estadoActivo)
        {
            Identidad = identidad;
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Correo = correo;
            Foto = foto;
            EstadoActivo = estadoActivo;
        }
    }
}
