using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{ 

    public class XCXP_NATU_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public double Saldo_inicial { get; set; }
        public Nullable<double> Debitos { get; set; }
        public Nullable<double> Creditos { get; set; }
        public double Saldo { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }

        public XCXP_NATU_Rpt004_Info()
        {

        }

    }
}
