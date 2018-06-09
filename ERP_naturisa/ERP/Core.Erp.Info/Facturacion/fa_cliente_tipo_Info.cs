using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
   public class fa_cliente_tipo_Info
    {
       public int IdEmpresa { get; set; }
       public int Idtipo_cliente { get; set; }
       public string Cod_cliente_tipo { get; set; }
       public string Descripcion_tip_cliente { get; set; }
       public string estado { get; set; }
       public string IdCtaCble_CXC_Con { get; set; }
       public string IdCtaCble_CXC_Cred { get; set; }
       public string IdCtaCble_CXC_Anticipo { get; set; }

       public string IdUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string MotivoAnula { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }


       public fa_cliente_tipo_Info()
       {

       }

       
       public fa_cliente_tipo_Info(int IdEmpresa_,int Idtipo_cliente_,string Cod_cliente_tipo_,
           string Descripcion_tip_cliente_,string estado_)
       {
           IdEmpresa = IdEmpresa_;
           Idtipo_cliente = Idtipo_cliente_;
           Cod_cliente_tipo = Cod_cliente_tipo_;
           Descripcion_tip_cliente = Descripcion_tip_cliente_;
           estado = estado_;
       }
    }
}
