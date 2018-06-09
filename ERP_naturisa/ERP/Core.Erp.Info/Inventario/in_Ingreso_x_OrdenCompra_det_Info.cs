using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_Ingreso_x_OrdenCompra_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdIngreso_x_oc { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double Cant { get; set; }
        public double Cant_a_recibir { get; set; }
        public double Cant_recibida { get; set; }
        public int IdEmpresa_oc { get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia_oc { get; set; }
        public string oc_NumDocumento { get; set; }
        public string IdUnidadMedida { get; set; }
        public string Ref_OC { get; set; }

       public double do_descuento { get; set; }
       public double do_subtotal { get; set; }
       public double do_iva { get; set; }
       public double do_total { get; set; }

       public string Descripcion { get; set; }
       public string IdUnidadMedida_Consumo { get; set; }

        #region prop para vista vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven
        public Boolean Checked { get; set; }

        public int IdSucursal { get; set; }
       //public decimal IdOrdenCompra { get; set; }
        public int secuencia_oc_det { get; set; }
        public string nom_sucu { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string Tipo { get; set; }
        public DateTime oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        //public decimal IdProducto { get; set; }
        public double oc_precio { get; set; }
        public int secuencia_inv_det { get; set; }
        public double cantidad_pedida_OC { get; set; }
        public double cantidad_ing_a_Inven { get; set; }
        public double Saldo_x_Ing_OC { get; set; }
        public double pr_stock { get; set; }
        public double pr_peso { get; set; }
        public double CostoProducto { get; set; }

        public string Estado { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdEstadoAprobacion { get; set; }

        public int? IdPunto_cargo_grupo { get; set; }
        public int? IdPunto_cargo { get; set; }
        public double Saldo_x_Ing_OC_AUX { get; set; }

        public string IdEstadoRecepcion { get; set; }

        public int IdMotivo_OC { get; set; }
        public string Nom_Motivo { get; set; }

        public double cantidad_ingresada { get; set; }

        public string IdEstado_cierre { get; set; }
        public string nom_estado_cierre { get; set; }

        public string Nomsub_centro_costo { get; set; }

        #endregion

       public  in_Ingreso_x_OrdenCompra_det_Info(){}
    }
}
