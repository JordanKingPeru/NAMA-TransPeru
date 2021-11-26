using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nama.Models
{
    /**
     * Task Model 
     */
    public class Noticia
    {

        [StringLength(50, MinimumLength = 3), Required]
        public string title { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [StringLength(50, MinimumLength = 3), Required]
        public string description  { get; set; }

        [StringLength(50, MinimumLength = 3), Required]
        public string url { get; set; }

        [StringLength(50, MinimumLength = 3), Required]
        public string tipo { get; set; }
        
    }
}
