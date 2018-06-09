/*CLASE: ro_empleado_x_Proyeccion_Gastos_Personales_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 04-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Proyeccion_Gastos_Personales
//10/01/2014
//Derek Mejía Soria
namespace Core.Erp.Info.Roles
{
    public class ro_empleado_x_Proyeccion_Gastos_Personales_Info
    {


        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdTipoGasto { get; set; }
        public int AnioFiscal { get; set; }
        public double Valor { get; set; }
        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
        public int Monto_max { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_tipo_gasto { get; set; }

        public ro_empleado_x_Proyeccion_Gastos_Personales_Info() { }

    }
}
