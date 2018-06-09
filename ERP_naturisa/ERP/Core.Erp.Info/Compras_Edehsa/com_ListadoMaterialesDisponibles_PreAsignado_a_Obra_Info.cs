using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras_Edehsa
{
    public class com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodObra_preasignada { get; set; }
        public int ot_IdSucursal { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Motivo { get; set; }
        public string lm_Observacion { get; set; }
        public string ob_descripcion { get; set; }
        public string su_descripcion { get; set; }
        

        public com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info() { }
    }
}
