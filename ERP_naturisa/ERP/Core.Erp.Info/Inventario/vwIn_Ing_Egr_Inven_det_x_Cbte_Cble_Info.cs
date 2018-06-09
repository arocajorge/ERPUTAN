using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNumMovi { get; set; }
        public decimal IdProducto { get; set; }
        public string IdEstadoAproba { get; set; }
        public int IdEmpresa_inv { get; set; }
        public int IdSucursal_inv { get; set; }
        public int IdBodega_inv { get; set; }
        public decimal IdNumMovi_inv { get; set; }
        public int IdMovi_inven_tipo_inv { get; set; }
        public int IdEmpresa_CbteCble { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipoCbte { get; set; }
        public string CodCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime cb_Fecha { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Observacion { get; set; }


        public vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info()
        {

        }
    }
}
