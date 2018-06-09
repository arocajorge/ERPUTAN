using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_transferencia_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int dt_secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dt_cantidad { get; set; }
        public string tr_Observacion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string IdUnidadMedida { get; set; }
        
       
        // carlos 
        public string Sucursal_Destino { get; set; }
        public string Sucursal_Origen { get; set; }
        public string Bodega_Destino { get; set; }
        public string Bodega_Origen { get; set; }
        public int cantidad_enviar { get; set; }
        public bool check { get; set; }

        public in_Guia_x_traspaso_bodega_det_Info Info_Guia_x_traspaso_bodega_det { get; set; }

        public in_transferencia_det_Info()
        {
            Info_Guia_x_traspaso_bodega_det = new in_Guia_x_traspaso_bodega_det_Info();
        }
    }
}
