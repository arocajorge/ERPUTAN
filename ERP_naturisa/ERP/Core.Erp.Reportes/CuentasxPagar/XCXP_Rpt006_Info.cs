using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Nota { get; set; }
        public int IdTipoCbte_Nota { get; set; }
        public string DebCre{ get; set; }
        public string IdTipoNota { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        //public money cn_total { get; set; }
        public String cn_Nota { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_Cuenta { get; set; }
        public string clave { get; set; }
        public int secuencia { get; set; }
        public double dc_Valor { get; set; }
        public double valor_debe { get; set; }
        public double valor_haber { get; set; }
        public string dc_Observacion { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_Proveedor { get; set; }
        public int IdSucursal { get; set; }
        public string nom_Sucursal { get; set; }
        public string nom_TipoCbte { get; set; }
        public string Nombre { get; set; }
        public string em_nombre { get; set; }

        public string debe { get; set; }
        public string haber { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
    


        public XCXP_Rpt006_Info() 
        {
        }
    }
}
