using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdVtaActivo { get; set; }
        public string Cod_VtaActivo { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public string Encargado { get; set; }
        public double ValorActivo { get; set; }
        public double Valor_Tot_Bajas { get; set; }
        public double Valor_Tot_Mejora { get; set; }
        public double Valor_Depre_Acu { get; set; }
        public double Valor_Neto { get; set; }
        public double Valor_Venta { get; set; }
        public double Valor_Perdi_Gana { get; set; }
        public string NumComprobante { get; set; }
        public string Concepto_Vta { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public Image Logo { get; set; }

        public XACTF_Rpt007_Info()
        {

        }
    }
}
