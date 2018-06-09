using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_Bodega_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public string cod_bodega { get; set; }
        public string bo_Descripcion { get; set; }
        public string bo_Descripcion2 { get; set; }
        public string cod_punto_emision { get; set; }
        public string bo_esBodega { get; set; }
        public string bo_manejaFacturacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public Boolean Estado { get; set; }
        public string NomSucursal { get; set; }

        public string IdCentroCosto { get; set; }
        public string EstaEnBase { get; set; }

        public Boolean Chek { get; set; }

        public string IdEstadoAproba_x_Ing_Egr_Inven { get; set; }

        public string IdCtaCtble_Inve { get; set; }
        public string IdCtaCtble_Costo { get; set; }


        public tb_Bodega_Info() 
        {
        EstaEnBase ="N";
        }
    }
}
