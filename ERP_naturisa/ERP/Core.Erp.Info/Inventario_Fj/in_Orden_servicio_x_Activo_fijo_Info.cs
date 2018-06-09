using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario_Fj
{
    public class in_Orden_servicio_x_Activo_fijo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenSer_x_Af { get; set; }
        public int IdBodega { get; set; }
        public int IdActivoFijo { get; set; }
        public decimal IdProveedor { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Num_Fact { get; set; }
        public string Num_Documento { get; set; }
        public string IdCentroCosto { get; set; }
        public string Observacion { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string motivoAnulacion { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string Estado { get; set; }

        public List<in_Orden_servicio_x_Activo_fijo_det_Info> List_in_Orden_servicio_x_Activo_fijo_det { get; set; }

        //Campos de la vista
        public string bo_Descripcion { get; set; }
        public string Af_Nombre { get; set; }
        public string Centro_costo { get; set; }
        public string pr_nombre { get; set; }
        public string Su_Descripcion { get; set; }
    }
}
