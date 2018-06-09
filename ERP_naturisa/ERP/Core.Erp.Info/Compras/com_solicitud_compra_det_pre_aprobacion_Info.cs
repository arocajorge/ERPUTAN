using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
   public class com_solicitud_compra_det_pre_aprobacion_Info
    {


       public int IdEmpresa { get; set; }
       public int IdPreAprobacion { get; set; }
       public int IdSucursal_SC { get; set; }
       public decimal IdSolicitudCompra { get; set; }
       public int Secuencia_SC { get; set; }
       public decimal? IdProducto_SC { get; set; }
       public string NomProducto_SC { get; set; }
       public double Cantidad_aprobada { get; set; }
       public string IdEstadoAprobacion { get; set; }
       public decimal IdProveedor_SC { get; set; }
       public string IdUsuarioAprueba { get; set; }
       public DateTime FechaHoraAprobacion { get; set; }
       public string observacion { get; set; }
       public string IdUnidadMedida { get; set; }
       public double do_precioCompra { get; set; }
       public double do_porc_des { get; set; }
       public double do_descuento { get; set; }
       public double do_subtotal { get; set; }
       public double do_iva { get; set; }
       public double do_total { get; set; }
       public string do_ManejaIva { get; set; }
       public string IdCentroCosto { get; set; }
       public string IdCentroCosto_sub_centro_costo { get; set; }
       public int? IdPunto_cargo { get; set; }
       public string do_observacion { get; set; }
      



        public  com_solicitud_compra_det_pre_aprobacion_Info(){}
    }
}
