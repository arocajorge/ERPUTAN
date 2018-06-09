using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
   public class com_solicitud_compra_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string NumDocumento { get; set; }
        public decimal IdSolicitante { get; set; }
        public decimal IdComprador { get; set; }
        public decimal IdDepartamento { get; set; }
        public DateTime fecha { get; set; }
        public int plazo { get; set; }
        public DateTime fecha_vtc { get; set; }
        public string observacion { get; set; }
        public string  Estado { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_EstadoAprobacion { get; set; }

        // campos adicionales de la vista vwcom_EstadoAprobacion_sol_compra
        public string IdTipoCatalogo { get; set; }
        public string Codigo { get; set; }
        public string Id { get; set; }
        public string descripcion { get; set; }
        public int Orden { get; set; }
        public string name { get; set; }
        // campos adicionales de la vista vwcom_EstadoAprobacion_sol_compra

        public string  IdEstadoAprobacion { get; set; }
        public string  IdUsuarioAprobo { get; set; }
        public string MotivoAprobacion { get; set; }
        public DateTime ? FechaHoraAprobacion { get; set; }

        public string IdEstadoAprobacion_SolCompra { get; set; }

        public List<com_solicitud_compra_det_Info> DetSolicitudCompra { get; set; }
       
        //campos detalle solicitud
        public decimal IdProducto { get; set; }
        public int Secuencia { get; set; }
        public double do_Cantidad { get; set; }
        public string NomProducto { get; set; }
        public string Referencia { get; set; }
        public Boolean Checked { get; set; }


        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int? IdPunto_cargo { get; set; }
        public string IdUnidadMedida { get; set; }

       //campos de la vista vwcom_solicitud_compra

        public string Sucursal { get; set; }
        public string Solicitante { get; set; }
        public string Comprador { get; set; }
        public string departamento { get; set; }

        public Boolean Mostrar_Icono_Buscar_OC { get; set; }



       public  com_solicitud_compra_Info()      
       {
           DetSolicitudCompra = new List<com_solicitud_compra_det_Info>();          
       }
    }
}
