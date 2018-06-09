using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt010_Info
    {

        public decimal IdCliente { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public double Monto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Su_Descripcion { get; set; }
        public double TotalCobrado { get; set; }
        public double Valor_Vencido { get; set; }
        public double x_Ven_0_30 { get; set; }
        public double x_Ven_181_999 { get; set; }
        public double x_Ven_31_60 { get; set; }
        public double x_Ven_61_90 { get; set; }
        public double x_Ven_91_180 { get; set; }
        public Image Logo { get; set; }


        public XCXC_Rpt010_Info()
        {

        }
    }
}
