using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
   public  class ct_Balance_x_General_x_Usuario_Info
    {

        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string NomCuenta { get; set; }
        public string Grupo_Contable { get; set; }
        public int IdNivel { get; set; }
        public double sc_saldo_anterior { get; set; }
        public double sc_saldo_Periodo { get; set; }
        public double sc_saldo_acum { get; set; }
        public string IdUsuario { get; set; }
        public string Nom_Pc { get; set; }
        public string IdCtaCblePadre { get; set; }

        public string Report_saldo_anterior { get; set; }
        public string Report__saldo_Periodo { get; set; }
        public string Report__saldo_acum { get; set; }
        
       
    }
}
