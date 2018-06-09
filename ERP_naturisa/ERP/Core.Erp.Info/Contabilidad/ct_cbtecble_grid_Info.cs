using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info
{
    public class ct_cbtecble_grid_Info
    {
        public string tipo_cbte { get; set; }
        public int num_cbte { get; set; }
        public string cod_cbte { get; set; }
        public DateTime fecha_cbte { get; set; }
        public double valor { get; set; }
        public string observacion { get; set; }

        public ct_cbtecble_grid_Info() { }
    }
}
