using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_Grupo_empleado_Info
   {
       public int IdEmpresa { get; set; }
       public int IdGrupo { get; set; }
       public string Nombre_Grupo { get; set; }
       public int Calculo_Horas_extras_Sobre { get; set; }
       public int Max_num_horas_sab_dom { get; set; }
       public string IdRubro_Alim { get; set; }
       public string IdRubro_Trans { get; set; }
       public double Valor_Alimen { get; set; }
       public double Valor_Transp { get; set; }
       public double Valor_bono { get; set; }
       public string IdUsuario { get; set; }
       public Nullable<System.DateTime> Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string Estado { get; set; }
       public string MotiAnula { get; set; }
       public List<ro_Grupo_empleado_det_Info> detalle { get; set; }

            public ro_Grupo_empleado_Info()
          {
          }
    }
}
