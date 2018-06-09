using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Core.Erp.Info.Compras
{
  public  class vwcom_solicitud_compra_x_items_con_saldos_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public string NumDocumento { get; set; }
        public decimal IdPersona_Solicita { get; set; }
        public decimal IdComprador { get; set; }
        public int IdDepartamento { get; set; }
        public DateTime fecha { get; set; }
        public int plazo { get; set; }
        public DateTime fecha_vtc { get; set; }
        public string observacion { get; set; }
        public string Estado { get; set; }
        public string Sucursal { get; set; }
        public string Solicitante { get; set; }
        public string Comprador { get; set; }
        public string departamento { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string nom_EstadoAprobacion { get; set; }
        public string IdUsuarioAprobo { get; set; }
        public string MotivoAprobacion { get; set; }
        public DateTime FechaHoraAprobacion { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double cant_solicitada { get; set; }
        public string NomProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int IdPunto_cargo { get; set; }
        public int IdMotivo { get; set; }
        public Nullable<double> Stock { get; set; }
      public int ? ocd_IdEmpresa { get; set; }
      public int ? ocd_IdSucursal { get; set; }
      public decimal ? ocd_IdOrdenCompra { get; set; }
      public Boolean Tiene_OC { get; set; }
      public string Nom_Centro_costo { get; set; }


        public Boolean Checked { get; set; }
        public Boolean Checked_Estado { get; set; }
        
        

        public Bitmap Ico1 { get; set; }
        public Bitmap Ico2 { get; set; }

        public double cant_aprobada_OC { get; set; }
        public double Saldo_cant_SolCom { get; set; }
        public double Saldo_can_SolCom { get; set; }
       
        public decimal IdProveedor { get; set; }
        public decimal IdProveedor_SC { get; set; }

        public double Saldo_cant_SolCom_AUX { get; set; }
        public double cant_aprobada_OC_AUX { get; set; }
        public string IdEstadoAprobacion_AUX { get; set; }
        public double cant_ing_SolCom_AUX { get; set; }

       
        public double Cantidad_aprobada { get; set; }
        public string observacion_Aprob { get; set; }
        public string IdUsuarioAprueba { get; set; }

        public double cant_ing_SolCom { get; set; }
        public string IdUnidadMedida { get; set; }


        public double do_precioCompra { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        //public bool do_ManejaIva { get; set; }        
        public string do_observacion { get; set; }

        public string Referencia { get; set; }

        public string IdEstadoPreAprobacion { get; set; }

        public string Nomsub_centro_costo { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }

             
        public vwcom_solicitud_compra_x_items_con_saldos_Info(){}
    }
}
