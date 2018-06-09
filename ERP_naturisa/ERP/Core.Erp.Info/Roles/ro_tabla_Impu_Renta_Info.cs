using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Tabla Impuestos a la renta
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Info.Roles
{
    public class ro_tabla_Impu_Renta_Info
    {
        public int AnioFiscal { get; set; }
        public int Secuencia { get; set; }
        public double? FraccionBasica { get; set; }
        public double? ExcesoHasta { get; set; }
        public double? ImpFraccionBasica { get; set; }
        public double? Por_ImpFraccion_Exce { get; set; }


        public ro_tabla_Impu_Renta_Info() { }

    }
}
