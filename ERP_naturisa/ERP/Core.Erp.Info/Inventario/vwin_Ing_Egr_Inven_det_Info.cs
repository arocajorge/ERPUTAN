using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class vwin_Ing_Egr_Inven_det_Info
    {

        public Boolean Checked { get; set; }

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_ante { get; set; }
        public double dm_stock_actu { get; set; }
        public string dm_observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public double dm_peso { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }

        public string IdEstadoAproba { get; set; }
        public string IdUnidadMedida { get; set; }
        public double mv_costo_sinConversion { get; set; }
        

        public double subtotal { get; set; }
        public string nom_medida { get; set; }

        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string nom_motivo { get; set; }
        public string nom_producto { get; set; }
        public string nom_tipo_inv { get; set; }
        public string nom_punto_cargo { get; set; }
        public string signo { get; set; }
        public Nullable<System.DateTime> cm_fecha { get; set; }
        public string IdEstadoAproba_AUX { get; set; }
        public double mv_costo_AUX { get; set; }
        public double subtotal_AUX { get; set; }

        public string IdCtaCtble_Gasto_x_cxp { get; set; }
        public string IdCentro_Costo_x_Gasto_x_cxp { get; set; }       
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }

        public string Motivo_Aprobacion { get; set; }
        public int IdPunto_cargo { get; set; }

        public string IdUnidadMedida_sinConversion { get; set; }
        public double dm_cantidad_sinConversion { get; set; }

        public Nullable<int> IdMotivo_Inv { get; set; }
        public string Estado { get; set; }

        public Nullable<System.DateTime> Fecha_registro { get; set; }
       public vwin_Ing_Egr_Inven_det_Info(){}
    }
}
