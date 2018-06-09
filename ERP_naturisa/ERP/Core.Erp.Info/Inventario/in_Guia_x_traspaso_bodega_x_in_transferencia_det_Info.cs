using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
   public class in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTransferencia { get; set; }
        public string observacion { get; set; }
        public int IdEmpresa_tras { get; set; }
        public int IdGuia { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public int dt_secuencia { get; set; }
        public decimal cantidad { get; set; }
        public string pr_descripcion { get; set; }
        public string bo_Descripcion_destino { get; set; }
        public string Sucursal_Destino { get; set; }
        public double dt_cantidad { get; set; }
        public string bo_Descripcion_origen { get; set; }
        public bool check { get; set; }
        public string tr_Observacion { get; set; }
        public decimal diferencia { get; set; }


    }
}
