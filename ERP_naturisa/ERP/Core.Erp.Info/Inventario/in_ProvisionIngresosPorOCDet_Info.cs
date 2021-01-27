using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_ProvisionIngresosPorOCDet_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdProvision { get; set; }
        public int Secuencia { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia_inv { get; set; }
        public double Costo { get; set; }

        #region Campos que no existen en la tabla
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string IdCtaCtble_Inve { get; set; }
        public string pc_Cuenta { get; set; }
        #endregion
    }
}
