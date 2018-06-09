using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
  public  class prd_OrdenesComprasPendientes_Info
  {
      public string NomProducto { get; set; }
       public bool check { get; set; }
       public int IdEmpresa { get; set; } 
       public int IdSucursal { get; set; }  
       public decimal IdOrdenCompra { get; set; }
       public decimal IdProveedor { get; set; }  
       public string oc_NumDocumento { get; set; }  
       public string Tipo { get; set; }  
       public string IdTerminoPago { get; set; }  
       public int oc_plazo { get; set; } 
       public DateTime oc_fecha { get; set; } 
       public float oc_flete	{ get; set; } 
       public string oc_observacion { get; set; }
       public string Estado { get; set; }
       public string IdEstadoAprobacion { get; set; }
       public DateTime co_fecha_aprobacion { get; set; }
	   public string IdUsuario_Aprueba { get; set; }
       public string IdUsuario_Reprue { get; set; }
       public DateTime co_fechaReproba { get; set; } 
       public DateTime Fecha_Transac { get; set; } 
       public DateTime Fecha_UltMod { get; set; } 
       public string IdUsuarioUltMod { get; set; }
       public DateTime FechaHoraAnul { get; set; } 
       public string IdUsuarioUltAnu { get; set; }
       public string EstadoRecepcion { get; set; }
       public string MotivoAnulacion { get; set; }
	   public string MotivoReprobacion { get; set; }
	   public string Solicitante { get; set; }
       public int IdPersona_Sol { get; set; }
	   public int IdDepartamento { get; set; }
	   public string IdUsuario { get; set; }
	   public int IdMotivo { get; set; }
	   public DateTime oc_fechaVencimiento { get; set; }
	   public string IdEstado_cierre { get; set; }
	   public int IdComprador { get; set; }
	   public string IdUnidadMedida { get; set; }
       public int do_observacion { get; set; }
	   public int do_peso { get; set; }
	   public string do_Costeado { get; set; }
	   public string do_ManejaIva { get; set; }
	   public double do_total { get; set; }
       public double do_iva { get; set; }
       public double do_subtotal { get; set; }
       public double do_descuento { get; set; }
       public double do_precioCompra { get; set; }
       public double do_Cantidad { get; set; }
	   public int IdProducto { get; set; }
	   public int Secuencia { get; set; }
    }
}
