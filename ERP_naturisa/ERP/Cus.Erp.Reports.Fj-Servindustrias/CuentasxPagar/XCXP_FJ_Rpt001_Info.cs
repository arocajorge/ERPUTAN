using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.CuentasxPagar
{
    public class XCXP_FJ_Rpt001_Info
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdSucursalOrigen { get; set; }
        public Nullable<int> IdBodegaOrigen { get; set; }
        public Nullable<decimal> IdTransferencia { get; set; }
        public Nullable<int> IdSucursalDest { get; set; }
        public Nullable<int> IdBodegaDest { get; set; }
        public string Sucursal_Origen { get; set; }
        public string Sucursal_Fin { get; set; }
        public string Bodega_Fin { get; set; }
        public string Bodega_Ini { get; set; }
        public string observacion { get; set; }
        public decimal cantidad { get; set; }
        public int dt_secuencia { get; set; }
        public string NumGuia { get; set; }
        public Nullable<decimal> IdGuia { get; set; }
        public string Direc_sucu_Partida { get; set; }
        public string Direc_sucu_Llegada { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Fecha_Traslado { get; set; }
        public Nullable<System.DateTime> Fecha_llegada { get; set; }
        public Nullable<System.TimeSpan> Hora_Traslado { get; set; }
        public Nullable<System.TimeSpan> Hora_Llegada { get; set; }
        public string pr_codigo { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string Motivo_traslado { get; set; }
        public string IdMotivo_Traslado { get; set; }
    }
}
