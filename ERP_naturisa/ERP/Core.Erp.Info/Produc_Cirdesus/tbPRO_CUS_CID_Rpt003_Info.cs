using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRO_CUS_CID_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public decimal IdListadoMateriales { get; set; }
        public string CodObra { get; set; }
        public DateTime FechaReg { get; set; }
        public string Usuario { get; set; }
        public string Su_Descripcion { get; set; }
        public string ot_descripcion { get; set; }



        public string ob_descripcion { get; set; }
        public string lm_Observacion { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public double Unidades { get; set; }
        public string IdEstadoAprob { get; set; }
        
        public tbPRO_CUS_CID_Rpt003_Info()
        {

        }
    }
}
