using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nama.Models
{
    /**
     * Avance Model 
     */
    public class Avance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAvance { get; set; }

        [StringLength(400)]
        public string Componente { get; set; }

        [StringLength(100)]
        public string Ubicacion { get; set; }

        [StringLength(100)]
        public string Provincia { get; set; }

        [StringLength(100)]
        public string MedioTransporte { get; set; }
        
        [StringLength(400)]
        public string Actividad { get; set; }
        
        [StringLength(100)]
        public string Indicador { get; set; }

        public int Anio { get; set; }
        public int Trimestre { get; set; }
        public double Gei { get; set; }
    }
}
