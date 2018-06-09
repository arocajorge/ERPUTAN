using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_Talonario_cheques_x_banco_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBanco { get; set; }
        public string Num_cheque { get; set; }
        public decimal ? secuencia { get; set; }
        public Boolean Usado { get; set; }
        public string S_Usado { get; set; }
        public string Estado { get; set; }
        public int ? IdEmpresa_cbtecble_Usado { get; set; }
        public decimal ? IdCbteCble_cbtecble_Usado { get; set; }
        public int ? IdTipoCbte_cbtecble_Usado { get; set; }
        public DateTime ? Fecha_uso { get; set; }
        public DateTime ? FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string IdUsuario_Anu { get; set; }
        public string ba_descripcion { get; set; }



        public int numdig { get; set; }
        public int ejemplo { get; set; }
        public int chqinicial { get; set; }
        public int chqfinal { get; set; }
        public int totalChq { get; set; }
        public string cuenta { get; set; }
	
    }
}
