using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GobusApp.Models
{
    public class Servicios
    {

        [Key]
        [Required(ErrorMessage = "El ServicioID ES REQUERIDO")]
        [MaxLength(10), MinLength(1)]
        // El ServicioID equivale a la clave primaria de la tabla Servicios
        public char ServicioID { get; set; }

        [MaxLength(50), MinLength(1)]
        // Equivale al nombre del Servicio
        public string NombreServicio { get; set; }

        [MaxLength(100), MinLength(1)]
        // Equivale a la Descripción del Servicio
        public string Descripción { get; set; }


        // Equivale al Costo del Servicio
        public double Costo { get; set; }



    }
}