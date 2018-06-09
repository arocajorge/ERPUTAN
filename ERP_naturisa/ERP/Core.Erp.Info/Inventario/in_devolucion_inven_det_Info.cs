using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
   public class in_devolucion_inven_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDev_Inven { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_movi_inv { get; set; }
        public int IdSucursal_movi_inv { get; set; }
        public int IdBodega_movi_inv { get; set; }
        public int IdMovi_inven_tipo_movi_inv { get; set; }
        public decimal IdNumMovi_movi_inv { get; set; }
        public int Secuencia_movi_inv { get; set; }
        public double cantidad_a_devolver { get; set; }
        public double cantidad_egresada { get; set; }
        public double cantidad_devuelta { get; set; }
        public Boolean Checked { get; set; }
        public string nom_punto_cargo { get; set; }


        public string nom_producto { get; set; }
        public string cod_producto { get; set; }

        public in_movi_inve_detalle_Info Info_movi_inven_det { get; set; }

        public in_devolucion_inven_det_Info()
        {
            Info_movi_inven_det = new in_movi_inve_detalle_Info();
        }


    }
}
