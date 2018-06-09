using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Importacion
{
    public class vwImp_OrdenCompraExt_X_CbteCble_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdCbte { get; set; }
        public string TipoComprobanteContable { get; set; }
        public string CodCbte { get; set; }
        public Double Valor { get; set; }
        public string TipoReg { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public Bitmap imp { get; set; }
        public vwImp_OrdenCompraExt_X_CbteCble_Info()
        {

        }
    }
}
