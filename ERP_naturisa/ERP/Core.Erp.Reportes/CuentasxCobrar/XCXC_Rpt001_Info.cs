using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt001_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public decimal IdCobro_a_aplicar { get; set; }
        public string cr_Codigo { get; set; }
        public string IdCobro_tipo { get; set; }
        public decimal IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public DateTime cr_fecha { get; set; }
        public int IdCalendario { get; set; }
        public int AnioFiscal { get; set; }
        public string NombreMes { get; set; }
        public string NombreCortoFecha { get; set; }
        public double cr_TotalCobro { get; set; }
        public DateTime cr_fechaDocu { get; set; }
        public DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string Referencia { get; set; }
        public string numDocumento { get; set; }
        public string IdTipoNotaCredito { get; set; }        

        public XCXC_Rpt001_Info ()
	    {

	    }

    }
}
