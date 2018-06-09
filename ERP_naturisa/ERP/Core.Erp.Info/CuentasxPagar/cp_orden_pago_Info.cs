using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_orden_pago_Info
    {
       public int  IdEmpresa {set; get;}         
       public decimal IdOrdenPago {set; get;}	
       public string Observacion	{set; get;}
       public string  IdTipo_op	{set; get;}
       public decimal IdProveedor	{set; get;}
       public  DateTime Fecha	{set; get;}
       public string  IdEstadoAprobacion	{set; get;}
       public string  IdFormaPago	{set; get;}
       public DateTime Fecha_Pago { set; get; }	
       public int? IdBanco	{set; get;}
       public string Estado { set; get; }

       public decimal? IdTipoFlujo { get; set; }
       public string EstadoCancelacion { get; set; }
    

       public decimal IdPersona { set; get; }
       public string IdTipo_Persona { set; get; }

       public decimal IdEntidad { set; get; }
       public string GeneraDiario { get; set; }
	
    
       public string pe_nombreCompleto { set; get; }

       public decimal Total_OP { set; get; }
       public decimal Total_cancelado { set; get; }
       public decimal Saldo { set; get; }

       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string MotiAnula { get; set; }
       public string IdUsuario { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string Descripcion { get; set; }

       public bool Check { get; set; }

      public List<cp_orden_pago_det_Info> Detalle { get; set; }
      public ct_Cbtecble_Info Info_CbteCble_x_OP { get; set; }

      

      public cp_orden_pago_Info()
      {
          Fecha = DateTime.Now.Date;
          Fecha_Pago = DateTime.Now.Date;
        //  Detalle = new List<vwcp_Cbte_x_pagar_OG_Info>();

          Detalle = new List<cp_orden_pago_det_Info>();
      
      }

    }
}
