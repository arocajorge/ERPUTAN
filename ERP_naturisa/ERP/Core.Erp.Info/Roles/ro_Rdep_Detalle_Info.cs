/*CLASE: ro_Rdep_Detalle_Info
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
    public class ro_Rdep_Detalle_Info:rdepRetRelDepDatRetRelDep
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int AnioFiscal { get; set; }
        public int Secuencia { get; set; }

        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }


        //VISTA vwRo_Rdep_Detalle
        public string Observacion { get; set; }
        public string EstadoRdep { get; set; }
        public string FechaRegistro { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }        
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string EstadoEmpleado { get; set; }
        public string StatusEmpleado { get; set; }
        

        public ro_Rdep_Detalle_Info() { }
    }
}
