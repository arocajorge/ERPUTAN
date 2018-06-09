using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_Ingreso_varios_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodMoviInven { get; set; }
        public string cm_observacion { get; set; }
        public DateTime cm_fecha { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdusuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }

        public int IdEmpresa_inv { get; set; }
        public int IdSucursal_inv { get; set; }
        public int IdBodega_inv { get; set; }
        public int IdMovi_inven_tipo_inv { get; set; }
        public decimal IdNumMovi_inv { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int IdEmpresa_x_Anu { get; set; }
        public int IdSucursal_x_Anu { get; set; }
        public int IdBodega_x_Anu { get; set; }
        public int IdMovi_inven_tipo_x_Anu { get; set; }
        public decimal IdNumMovi_x_Anu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string IdEstadoAproba { get; set; }

       //campos vista vwin_Ingreso_varios
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string tm_descripcion { get; set; }

        public List<in_Ingreso_varios_det_Info> listIngVarios { get; set; }

             		
        public  in_Ingreso_varios_Info()
        {
            listIngVarios = new List<in_Ingreso_varios_det_Info>();
        
        }
    }
}
