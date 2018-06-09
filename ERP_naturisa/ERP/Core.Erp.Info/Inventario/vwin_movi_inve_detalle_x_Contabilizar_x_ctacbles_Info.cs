using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
   public class vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info
    {

       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public int IdMovi_inven_tipo { get; set; }
       public decimal IdNumMovi { get; set; }
       public int Secuencia { get; set; }
       public string mv_tipo_movi { get; set; }
       public decimal IdProducto { get; set; }
       public string cod_producto { get; set; }
       public string nom_producto { get; set; }
       public double dm_cantidad { get; set; }
       public double dm_stock_ante { get; set; }
       public double dm_stock_actu { get; set; }
       public string dm_observacion { get; set; }
       public double mv_costo { get; set; }
       public double subtotal { get; set; }
       public double  dm_peso { get; set; }
       public DateTime cm_fecha { get; set; }
       public DateTime ? Fecha_Transac { get; set; }

       public int IdTipoCbte { get; set; }
       public string nom_tipo_mov_inv { get; set; }
       public string nom_TipoCbte { get; set; }
       public string nom_bodega { get; set; }
       public string nom_sucursal { get; set; }
       public int ?IdPunto_cargo { get; set; }
       public int ?IdPunto_cargo_grupo { get; set; }
       
       public int ? IdMotivo_Inv { get; set; }
       public int? IdMotivo_Inv_det { get; set; }

       
       public string IdCentro_Costo_x_MoviInv { get; set; }
       public string IdSubCentro_Costo_x_MoviInv { get; set; }
       public string IdCategoria { get; set; }
       public int IdLinea { get; set; }
       public int IdGrupo { get; set; }
       public int IdSubGrupo { get; set; }

       public string IdCtaCtble_Inve_x_Bod { get; set; }
       public string IdCtaCtble_Costo_x_Bod { get; set; }
       public string IdCtaCble_Inven_x_Motivo { get; set; }
       public string IdCtaCble_Costo_x_Motivo { get; set; }
       public string IdCtaCble_Inven_x_Motivo_det { get; set; }
       public string IdCtaCble_Costo_x_Motivo_det { get; set; }
       public string IdCtaCble_Inven_x_Prod { get; set; }
       public string IdCtaCble_Costo_x_Prod { get; set; }

       public string IdCtaCtble_Inve_x_SubGrupo { get; set; }
       public string IdCtaCtble_Costo_x_SubGrupo { get; set; }

       public ein_Inventario_O_Consumo es_Inven_o_Consumo { get; set; }
       public ein_Inventario_O_Consumo es_Inven_o_Consumo_det { get; set; }

       public bool check { get; set; }



    }
}
