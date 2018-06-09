using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
   public class vwin_movi_inve_x_cbteCble_Datos_Info
    {

       public int? IdEmpresa { get; set; }
       public int? IdSucursal { get; set; }
       public int? IdBodega { get; set; }
       public int? IdMovi_inven_tipo { get; set; }
       public decimal? IdNumMovi { get; set; }
       public string cm_observacion { get; set; }
       public DateTime cm_fecha { get; set; }
       public string codigo { get; set; }
       public string bo_Descripcion { get; set; }
       public string cm_tipo_movi { get; set; }
       public string cm_descripcionCorta { get; set; }
       public int? Secuencia { get; set; }
       public decimal IdProducto { get; set; }
       public string pr_codigo { get; set; }
       public string pr_descripcion { get; set; }
       public string dm_observacion { get; set; }
       public double dm_cantidad { get; set; }
       public double mv_costo { get; set; }
       public double TotalCosto { get; set; }
       public string IdCentroCosto { get; set; }
       public int ? IdPunto_cargo_grupo { get; set; }
       public int ? IdPunto_cargo { get; set; }
       public string nom_punto_cargo { get; set; }
       public string tc_TipoCbte { get; set; }
       public DateTime ? cb_Fecha { get; set; }
       public int ? IdEmpresa_ct { get; set; }
       public int ? IdTipoCbte { get; set; }
       public decimal  ? IdCbteCble { get; set; }
       public string tm_descripcion { get; set; }

       public int IdEmpresa_inv { get; set; }
       public int IdSucursal_inv { get; set; }
       public int IdBodega_inv { get; set; }
       public int IdMovi_inven_tipo_inv { get; set; }
       public decimal IdNumMovi_inv { get; set; }

       public bool cheked { get; set; }





       //Propiedades para imagenes
       public bool Modificar_producto { get; set; }
       public bool Modificar_contabilidad { get; set; }
    }
}
