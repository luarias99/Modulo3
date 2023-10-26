using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FormaPago
    {
        [Required(ErrorMessage = "El id es obligatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set;} = string.Empty;   
        public bool EstadoActivo { get; set;}

        public FormaPago()
        {
        }

        public FormaPago(int id, string nombre, bool estadoActivo)
        {
            Id = id;
            Nombre = nombre;
            EstadoActivo = estadoActivo;
        }
    }
}
