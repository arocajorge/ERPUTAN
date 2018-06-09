using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRO_CUS_CID_Rpt009_Info
    {
        public int? IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public string CodObra { get; set; }
        public decimal IdLider { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string Su_Descripcion { get; set; }
        public string ob_descripcion { get; set; }
        public string ot_descripcion { get; set; }
        public string gt_Descripcion { get; set; }
        public string et_descripcion { get; set; }
        public string mp_descripcion { get; set; }
        public string lider { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Observacion { get; set; }

        public tbPRO_CUS_CID_Rpt009_Info()
        {

        }
    }
}
