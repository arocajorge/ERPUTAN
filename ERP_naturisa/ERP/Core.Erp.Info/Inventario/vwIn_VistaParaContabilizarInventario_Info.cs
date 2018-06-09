using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class vwIn_VistaParaContabilizarInventario_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public string mv_tipo_movi { get; set; }
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_ante { get; set; }
        public double dm_stock_actu { get; set; }
        public string dm_observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public Nullable<double> dm_peso { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }

        public System.DateTime cm_fecha { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public string pr_descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public string tc_TipoCbte { get; set; }
        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public bool chek { get; set; }
        public string pr_codigo { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_Cargo { get; set; }
        public Nullable<int> IdMotivo_inven { get; set; }
        public string IdCtaCble_Inven_Motivo { get; set; }
        public string IdCtaCble_Costo_Motivo { get; set; }

        public vwIn_VistaParaContabilizarInventario_Info()
        {

        }

       
    }
}
