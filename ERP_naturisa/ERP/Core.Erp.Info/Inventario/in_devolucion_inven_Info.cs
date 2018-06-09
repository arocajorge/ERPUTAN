using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
   public class in_devolucion_inven_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDev_Inven { get; set; }
        public string cod_Dev_Inven { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool Devuelve_toda_tran { get; set; }
        public string estado { get; set; }
        public int IdSucursal_movi_inven { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdusuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string observacion { get; set; }
        public string MotivoAnulacion { get; set; }

       public string nom_sucursal { get; set; }
       public string nom_bodega { get; set; }
       




        public List<in_devolucion_inven_det_Info> lista_detalle { get; set; }

        public in_devolucion_inven_Info()
        {
            lista_detalle = new List<in_devolucion_inven_det_Info>();
        }


    }
}
