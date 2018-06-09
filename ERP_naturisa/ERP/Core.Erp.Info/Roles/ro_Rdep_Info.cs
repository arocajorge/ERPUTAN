/*CLASE: ro_Rdep_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 05-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.class_sri.RDEP;


namespace Core.Erp.Info.Roles
{
    public class ro_Rdep_Info:rdepRetRelDepDatRetRelDep
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int AnioFiscal { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }

        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }

        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        //VISTA
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string EstadoEmpleado { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string StatusEmpleado { get; set; }
        public string NomCompleto { get; set; }
        public string CedulaRuc { get; set; }

        //OTROS
        public Boolean Check { get; set; } 

        public ro_Rdep_Info() { }

    }
}
