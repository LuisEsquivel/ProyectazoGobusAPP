using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GobusApp.Models
{
    public class Sucursales
    {


        [Key]
        [MaxLength(10), MinLength(1)]
        [Required(ErrorMessage = "El SucursalD es requerido")]
        // El SucursalID es la clave primaria de la tabla Sucursales
        public char SucursalID { get; set; }

        [MaxLength(50), MinLength(1)]
        // Equivale al nombre de la Sucursal
        public string Nombre { get; set; }

        [MaxLength(100), MinLength(1)]
        // Equivale a la Dirección de la Sucursal
        public string Direccion { get; set; }

        [MaxLength(20), MinLength(1)]
        // Equivale al Telefono de la Sucursal
        public string Telefono { get; set; }

        [MaxLength(50), MinLength(1)]
        // Equivale al encargado de la Sucursal
        public string Encargado { get; set; }

    }
}