using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_Aprobacion_Ing_Bod_x_OC_det_Info
    {

        public int IdEmpresa { get; set; }  
        public decimal IdAprobacion { get; set; }
        public int Secuencia { get; set; }

        public int IdEmpresa_Ing_Egr_Inv { get; set; } 
        public int IdSucursal_Ing_Egr_Inv { get; set; }
        public int IdMovi_inven_tipo_Ing_Egr_Inv { get; set; }
        public decimal IdNumMovi_Ing_Egr_Inv { get; set; } 
        public int Secuencia_Ing_Egr_Inv { get; set; }

        public double Cantidad { get; set; } 
        public double Costo_uni { get; set; }
        public double Descuento { get; set; }  
        public double SubTotal { get; set; }
        public double PorIva { get; set; }  
        public double valor_Iva { get; set; } 
        public double Total { get; set; }

        public Boolean Checked { get; set; }

        public double subtotal0{ get; set; }
        public double subtotaliva { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public string IdCtaCble_IVA { get; set; }


       public string IdCtaCtble_Gasto_x_cxp_x_Produc { get; set; }
       public string IdCtaCble_Inven_x_Produc { get; set; }
       public string IdCtaCtble_Inve_x_Bodega { get; set; }
       public string IdCtaCble_Inven_x_Motivo { get; set; }
       public string IdCtaCble_Costo_x_Motivo { get; set; }
       public string IdCategoria { get; set; }
       public int IdLinea { get; set; }
       public int IdGrupo { get; set; }
       public int IdSubGrupo { get; set; }

        public string IdCentro_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int? IdPunto_cargo { get; set; }
        public int? IdPunto_cargo_grupo { get; set; }

        public string Nomsub_centro_costo { get; set; }
        public int Dias { get; set; }
        //  #region prop para vista vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det
        #region prop para vista vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_x_cp_Aprobacion_Ing_Bod_x_OC_det

        public string nom_centro_costo { get; set; }
        public string nom_sub_centro_costo { get; set; }


        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_medida { get; set; }
        public double do_porc_des { get; set; }
        //public bool do_ManejaIva { get; set; }
        public int IdBodega { get; set; }
        public int Secuencia_OC { get; set; }
        public int IdSucursal_OC { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }

        public DateTime Fecha_Ing_Bod { get; set; }

        public decimal IdOrdenCompra { get; set; }
        #endregion


        public ein_Inventario_O_Consumo es_Inven_o_Consumo { get; set; }
        public string S_es_Inven_o_Consumo { get; set; }
                       
       public cp_Aprobacion_Ing_Bod_x_OC_det_Info(){}
    }
}
