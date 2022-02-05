using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyectofinal.Models
{
    public class prestamos
    {
        [Key]
        public int Id { get; set; }
       
        [StringLength(100)]
        [Required(ErrorMessage ="Este campo es requerido")]
        public string Nombre { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Apellido { get; set; }
        
        [StringLength(100)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Cedula { get; set; }
        
        [StringLength(500)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Direccion { get; set; }
        
        [StringLength(30)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Telefono { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Fecha_de_Prestamo { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Monto { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Interes { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Plazo { get; set; }

        [StringLength(20)]
        public int Edad { get; set; }
    }
}
