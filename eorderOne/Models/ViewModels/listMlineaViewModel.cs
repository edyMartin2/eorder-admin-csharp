using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eorderOne.Models.ViewModels
{
    public class listMlineaViewModel
    {
        public int ID_EMPRESA { get; set; }
        public int ID_LOCAL { get; set; }
        public int ID_LINEA { get; set; }
        public string linea { get; set; }
        //public int w_order { get; set; }
    }
}