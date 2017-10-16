using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GobusApp.Models
{
    public class Citas
    {


        [Key]
        [MaxLength(10), MinLength(1)]
        [Required(ErrorMessage = "El CitasID es requerida")]
        // El CitasID equivale a la clave primaria de la table Citas
        public char CitasID { get; set; }


        [ForeignKey("Clientes")]
        [MaxLength(10), MinLength(1)]
        // Es una clave foránea que viene de la tabla Clientes
        public char CienteID { get; set; }


        [MaxLength(10), MinLength(1)]
        // Es una PlacaNumero
        public char PlacaNumero { get; set; }


        // Equivale a la fecha en que se realiza la cita
        public DateTime FechaCita { get; set; }


        [ForeignKey("Sucursales")]
        [MaxLength(10), MinLength(1)]
        // Es una clave foránea que viene de la tabla Sucursales
        public char SucursalID { get; set; }


    }
}