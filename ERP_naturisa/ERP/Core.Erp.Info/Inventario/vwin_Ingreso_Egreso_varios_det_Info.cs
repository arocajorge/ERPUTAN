using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class vwin_Ingreso_Egreso_varios_det_Info
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

        public double subtotal { get; set; }
        public string nom_Medida { get; set; }

        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public string cm_tipo_movi { get; set; }

        public string IdEstadoAproba_AUX { get; set; }
        public double mv_costo_AUX { get; set; }
        public double subtotal_AUX { get; set; }



       public vwin_Ingreso_Egreso_varios_det_Info(){}
    }
}
