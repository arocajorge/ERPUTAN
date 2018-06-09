using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Info.Inventario
{
    public class in_subgrupo_info
    {

        public int IdEmpresa { get; set; }
        public string IdCategoria { get; set; }
        public int IdLinea { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubgrupo { get; set; }
        public string cod_subgrupo { get; set; }
        public string nom_subgrupo { get; set; }
        public string Estado { get; set; }
        public string abreviatura { get; set; }


        public string observacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }

         public string nom_pc { get; set; }
         public string ip { get; set; }
         public string MotiAnula { get; set; }
         public string IdUsuarioUltMod { get; set; }

        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }

         public string IdCtaCtble_Inve { get; set; }
         public string IdCtaCtble_Costo { get; set; }
         public string IdCtaCtble_Gasto_x_cxp { get; set; }

         public string IdCentro_Costo_Inv { get; set; }
         public string IdCentro_Costo_Cost { get; set; }        
         public string IdCentro_Costo_x_Gasto_x_cxp { get; set; }

         public string IdCentroCosto_sub_centro_costo_inv { get; set; }
         public string IdCentroCosto_sub_centro_costo_cost { get; set; }
         public string IdCentroCosto_sub_centro_costo_cxp { get; set; }

         public string IdCtaCble_Vta { get; set; }
         public string IdCtaCble_CosBaseIva { get; set; }
         public string IdCtaCble_CosBase0 { get; set; }
         public string IdCtaCble_VenIva { get; set; }
         public string IdCtaCble_Ven0 { get; set; }
         public string IdCtaCble_DesIva { get; set; }
         public string IdCtaCble_Des0 { get; set; }
         public string IdCtaCble_DevIva { get; set; }
         public string IdCtaCble_Dev0 { get; set; }


         public in_subgrupo_info()
        {
                
        }

    }
}
