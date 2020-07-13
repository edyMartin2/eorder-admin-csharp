using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace eorderOne.Models.ViewModels
{
    public class tableMlineaViewModel
    {
        [Required]
        public int ID_EMPRESA { get; set; }
        [Required]
        public int ID_LOCAL { get; set; }
        [Required]
        public int ID_LINEA { get; set; }
        [Required]
        [StringLength(50)]
        public string linea { get; set; } 

    }
}