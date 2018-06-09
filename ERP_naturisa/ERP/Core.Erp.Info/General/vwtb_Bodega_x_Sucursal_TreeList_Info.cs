using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class vwtb_Bodega_x_Sucursal_TreeList_Info
    {
        public int IdEmpresa { get; set; }
        public string ID { get; set; }
        public string IdPadre { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public int Nivel { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public Boolean Checked { get; set; }
        public Boolean EstaEnBase { get; set; }

        public string IdCtaCble_Vta { get; set; }
        public string IdCtaCble_CosBaseIva { get; set; }
        public string IdCtaCble_CosBase0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_DesIva { get; set; }
        public string IdCtaCble_Des0 { get; set; }
        public string IdCtaCble_DevIva { get; set; }
        public string IdCtaCble_Dev0 { get; set; }

        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string IdCtaCble_Gasto_x_cxp { get; set; }

        public string IdCentro_Costo_Costo { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentroCosto_x_Gasto_x_cxp { get; set; }

        public string IdCentroCosto_sub_centro_costo_inv { get; set; }
        public string IdCentroCosto_sub_centro_costo_cost { get; set; }
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }

        public double pr_precio_publico { get; set; }

        public vwtb_Bodega_x_Sucursal_TreeList_Info()
        {

        }
    }
}
