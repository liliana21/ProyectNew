using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProyectNew.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Todo empleado debe tener un nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }
    }
}