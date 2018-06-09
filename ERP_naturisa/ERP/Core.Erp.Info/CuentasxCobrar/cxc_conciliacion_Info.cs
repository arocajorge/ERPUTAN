using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
   public class cxc_conciliacion_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public decimal IdConciliacion { get; set; }
       public DateTime Fecha { get; set; }
       public string  Observacion { get; set; }
       public decimal IdCliente { get; set; }
       public string Estado { get; set; }
       public string IdUsuario { get; set; }
       public DateTime Fecha_Transaccion { get; set; }
       public string  IdUsuarioUltModi { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string MotivoAnulacion { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }

       //haac 11/03/2014
       //campos de la vista vwcxc_conciliacion
       public string pe_nombreCompleto { get; set; }
       public string Su_Descripcion { get; set; }

       public int IdEmpresa_cbte_cble { get; set; }
       public int IdTipoCbte_cbte_cble { get; set; }
       public decimal IdCbteCble_cbte_cble { get; set; }


       public List<cxc_conciliacion_det_Info> Detalle { get; set; }
       public List<cxc_conciliacion_det_Info> DetalleCobroFact { get; set; }
       public cxc_cobro_Info cxc_cobro_Info { get; set; }

       public cxc_conciliacion_Info() 
       {
           Detalle = new List<cxc_conciliacion_det_Info>();     
       }
    }
}
