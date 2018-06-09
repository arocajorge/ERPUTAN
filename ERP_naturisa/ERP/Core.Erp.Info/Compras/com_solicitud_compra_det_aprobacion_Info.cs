using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Core.Erp.Info.Compras
{
  public  class com_solicitud_compra_det_aprobacion_Info
    {

        public int  IdEmpresa { get; set; }
        public int IdSucursal_SC { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia_SC { get; set; }
        public decimal? IdProducto_SC { get; set; }
        public string NomProducto_SC { get; set; }
        public double Cantidad_aprobada { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public decimal? IdProveedor_SC { get; set; }
        public string Nom_Proveedor_SC { get; set; }
        public string IdEstadoAprobacion_AUX { get; set; }
        public int IdMotivo { get; set; }
        public Boolean Checked { get; set; }
        public Boolean Checked_Estado { get; set; }
        public string IdUsuarioAprueba { get; set; }
        public DateTime FechaHoraAprobacion { get; set; }
        public string  observacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public double do_precioCompra { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        //public bool do_ManejaIva { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int? IdPunto_cargo { get; set; }
        public string do_observacion { get; set; }
        public Boolean Paga_Iva { get; set; }
        public string Graba_Estado { get; set; }

       //campos de la vista vwcom_solicitud_compra_x_items_con_saldos
       public DateTime fecha { get; set; }
       public string Solicitante { get; set; }
       public decimal IdComprador { get; set; }
       public decimal IdPersona_Solicita { get; set; }
       public int  IdDepartamento { get; set; }
       public decimal IdProveedor { get; set; }
       public int Secuencia { get; set; }

       public string IdEstadoPreAprobacion { get; set; }
       public string IdCod_Impuesto_Iva { get; set; }

       public int IdSucursal_x_OC { get; set; }

     
      public  com_solicitud_compra_det_aprobacion_Info()
      {
          
      }
    }
}
