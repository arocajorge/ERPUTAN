using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles.AGP
{
    public class detalleGasto
    {

        public string rucProveedor { get; set; }
        public decimal totalComprobantesVenta { get; set; }
        public decimal totalBaseImponible { get; set; }
        public int tipoGasto { get; set; }

        public detalleGasto()
        {

        }
    }
}
