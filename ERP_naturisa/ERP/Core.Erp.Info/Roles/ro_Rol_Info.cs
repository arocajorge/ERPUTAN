
/*CLASE: ro_Rol_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 17-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Rol_Info
    {
        public int IdEmpresa{get;set;}
        public int IdNominaTipo {get;set;}
        public int IdNominaTipoLiqui{get;set;}
        public int IdPeriodo{get;set;}
        public string IdCentroCosto { get; set; }
        public string Descripcion{get;set;}
        public string Observacion{get;set;}
        public string Cerrado { get; set; }
        public DateTime FechaIngresa{get;set;}
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica{get;set;}
        public string UsuarioModifica { get; set; }
        public DateTime? FechaAnula{get;set;}
        public string UsuarioAnula{get;set;}
        public string MotivoAnula{get;set;}
        public string UsuarioCierre{get;set;}
        public DateTime? FechaCierre { get; set; }

        public ro_Rol_Info() { }


    }
}
