using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//ULT. MOD = DEREK MEJIA 12/02/2014
namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cancelacion_Intercompany_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCancelacion { get; set; }
        public int Secuencia { get; set; }
        public int cbteVta_IdEmpresa { get; set; }
        public int cbteVta_IdSucursal { get; set; }
        public int cbteVta_IdBodega { get; set; }
        public string cbteVta_TipoDoc { get; set; }
        public decimal cbteVta_IdCbteVta { get; set; }
        public int? cbr_IdEmpresa { get; set; }
        public int? cbr_IdSucursal { get; set; }
        public decimal? cbr_IdCobro { get; set; }
        public double Valor_Aplicado { get; set; }

        ////Detalle:Cobros        
        //public int IdSucursal { get; set; }
        //public decimal IdCobro { get; set; }
        //public int secuencial { get; set; }
        //public string dc_TipoDocumento { get; set; }
        //public int IdBodega_Cbte { get; set; }
        //public decimal IdCbte_vta_nota { get; set; }
        //public double dc_ValorPago { get; set; }
        //public string IdUsuario { get; set; }
        //public DateTime Fecha_Transac { get; set; }
        //public string IdUsuarioUltMod { get; set; }
        //public DateTime Fecha_UltMod { get; set; }
        //public string IdUsuarioUltAnu { get; set; }
        //public DateTime Fecha_UltAnu { get; set; }
        //public string nom_pc { get; set; }
        //public string ip { get; set; }
        //public string estado { get; set; } 


        public cxc_cancelacion_Intercompany_det_Info() { }

    }
}
