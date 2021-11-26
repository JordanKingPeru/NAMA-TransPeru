using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nama.Models
{
    /**
     * Reporte Model 
     */
    public class Reporte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReporte { get; set; }

        [StringLength(50, MinimumLength = 2), Required]
        public string actividad { get; set; }

        [StringLength(50, MinimumLength = 2), Required]
        public string trimestre { get; set; }

        [StringLength(250, MinimumLength = 2), Required]
        public string description  { get; set; }

        [StringLength(50, MinimumLength = 2), Required]
        public string entidad { get; set; }
        
        [StringLength(50, MinimumLength = 2), Required]
        public string username { get; set; }
        
        [StringLength(50, MinimumLength = 2), Required]
        public string filename { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
