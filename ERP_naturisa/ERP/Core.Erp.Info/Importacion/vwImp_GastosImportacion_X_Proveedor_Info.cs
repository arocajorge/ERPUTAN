using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class vwImp_GastosImportacion_X_Proveedor_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRegistroGasto { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public int? IdTipoCbte { get; set; }
        public decimal? IdCbteCble { get; set; }
        public int? IdTipoCbte_Anu { get; set; }
        public decimal? IdCbteCble_Anu { get; set; }
        public string ga_descripcion { get; set; }
        public double Valor { get; set; }
        public string Observacion { get; set; }
        public string CodDocu_Pago { get; set; }
        public int IdGastoImp { get; set; }
        public int Secuencia { get; set; }
        public vwImp_GastosImportacion_X_Proveedor_Info(){}

    }
}
