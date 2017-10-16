using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GobusApp.Models
{
    public class Clientes
    {



        [Key]
        [MaxLength(10), MinLength(1)]
        [Required(ErrorMessage = "El ClienteID es requerido")]
        //Clave Primaria de la tabal Clientes
        public char ClienteID { get; set; }

        [MaxLength(50), MinLength(1)]
        // Equivale al nombre de los clientes 
        public string Nombres { get; set; }

        [MaxLength(100), MinLength(1)]
        // Equivale al apellido de los clientes
        public string Apellidos { get; set; }

        [MaxLength(200), MinLength(1)]
        // Equivale a la Dirección de los clientes 
        public string Direccion { get; set; }

        [MaxLength(20), MinLength(1)]
        // Equivale al Telefono de los clientes 
        public string Telefono { get; set; }

        [MaxLength(20), MinLength(1)]
        // Equivale al Correo de los clientes 
        public string Email { get; set; }

    }
}