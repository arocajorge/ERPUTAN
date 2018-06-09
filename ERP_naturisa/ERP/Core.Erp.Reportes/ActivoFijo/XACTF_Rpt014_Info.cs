using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt014_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string Af_Descripcion { get; set; }
        public Nullable<double> Af_costo_compra { get; set; }
        public Nullable<double> Valor_Depreciacion { get; set; }
        public double Valor_ult_depreciacion { get; set; }
        public Nullable<double> Costo_neto { get; set; }

        public XACTF_Rpt014_Info ()
	    {

	    }
    }
}
