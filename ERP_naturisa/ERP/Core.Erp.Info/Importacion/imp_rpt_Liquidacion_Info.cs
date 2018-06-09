using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
namespace Core.Erp.Info.Importacion
{
    public class imp_rpt_Liquidacion_Info
    {

        public string Importacion { get; set; }
        public string IdInterno { get; set; }
        public string DiarioCompra { get; set; }
        public string DiarioLiquidacion { get; set; }
        public string Proveedor { get; set; }
        public string FacturaProveedor { get; set; }
        public DateTime Llegada { get; set; }
        public double Tonelada { get; set; }
        public String Observacion { get; set; }
        public double CFR { get; set; }
        public double Flete { get; set; }
        public double Total { get; set; }
        public double totalImportacion { get; set; }
        public double usdImportacion { get; set; }
        public double TotalNacionalizacion { get; set; }
        public double USDNacionalizacion { get; set; }
        public List<vwImp_LiquidacionImportacion_Info> ListaDetalle { get; set; }
        public tb_Empresa_Info InfoEmpresa { get; set; }
        public imp_rpt_Liquidacion_Info()
        {
            ListaDetalle = new List<vwImp_LiquidacionImportacion_Info>();
        }

        


    }
}
