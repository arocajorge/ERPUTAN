using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_retencion_Info
    {
        public int IdEmpresa { get; set; }

        public int ? IdEmpresa_Ogiro { get; set; }
        public decimal ?IdCbteCble_Ogiro { get; set; }
        public int ? IdTipoCbte_Ogiro { get; set; }
        public decimal IdRetencion { get; set; }
        public string observacion { get; set; }
        public System.DateTime fecha { get; set; }
        public string NAutorizacion { get; set; }

        public string CodDocumentoTipo { get; set; }
        public string S_Serie { get; set; }
        public string serie1 { get; set; }
        public string serie2 { get; set; }
        public string NumRetencion { get; set; }

        public bool EsDocumentoElectronico { get; set; }
        public Nullable<int> ct_IdEmpresa_Anu { get; set; }
        public Nullable<int> ct_IdTipoCbte_Anu { get; set; }
        public Nullable<decimal> ct_IdCbteCble_Anu { get; set; }
        public int IdCbte_CXP { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public System.DateTime Fecha_Transac { get; set; }
        public DateTime? Fecha_Autorizacion { get; set; }



        public string Estado_Auto { get; set; }
        public string Tipo_Documento { get; set; }
        

        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

        public string TipoDocumento { get; set; }
                public string NomProveedor { get; set; }
        public decimal? IdProveedor { get; set; }
        public string ced_ruc_proveedor { get; set; }

        
        
        public string re_Tiene_RTiva { get; set; }
        public string re_Tiene_RFuente { get; set; }
        public string re_EstaImpresa { get; set; }


        public List<cp_retencion_det_Info> ListDetalle { get; set; }
        public cp_retencion_det_Info Info_det_retencion { get; set; }
        public tb_sis_Documento_Tipo_Talonario_Info Info_Documento_talonario_Actual { get; set; }
        public ct_Cbtecble_Info Info_CbteCble_x_RT { get; set; }

        public string Factura_Prov { get; set; }
        public DateTime ? co_FechaFactura { get; set; }

        public Nullable<double> Total_Retencion { get; set; }



        public cp_retencion_Info() 
        {
            Info_Documento_talonario_Actual = new tb_sis_Documento_Tipo_Talonario_Info();
            ListDetalle = new List<cp_retencion_det_Info>();
            Info_CbteCble_x_RT = new ct_Cbtecble_Info();
            Info_det_retencion = new cp_retencion_det_Info();

        }
    }
}

