using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt008_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCliente { get; set; }
        public string Su_Descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public double Monto { get; set; }
        public double TotalCobrado { get; set; }
        public double Valor_Vencido { get; set; }
        public double Valor_x_Vencer { get; set; }
        public Image Logo { get; set; }

        public XCXC_Rpt008_Info()
        {
                
        }
    }
}
