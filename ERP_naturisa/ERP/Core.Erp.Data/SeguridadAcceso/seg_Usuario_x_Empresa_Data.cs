using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.SeguridadAcceso
{
   public class seg_Usuario_x_Empresa_Data
    {


       public List<seg_Usuario_x_Empresa_info> Get_List_Usuario_x_Empresa(string IdUsuario)
       {
           try
           {
               List<seg_Usuario_x_Empresa_info> lista = new List<seg_Usuario_x_Empresa_info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {



                   var q = from C in DBBase.vwseg_Usuario_x_Empresa
                           where C.IdUsuario == IdUsuario
                           select C;

                   foreach (var item in q)
                   {
                       seg_Usuario_x_Empresa_info Info = new seg_Usuario_x_Empresa_info();

                       Info.IdUsuario = item.IdUsuario;
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.Observacion = item.Observacion;
                       Info.em_ruc= item.em_ruc;
                       Info.em_nombre = item.em_nombre;

                       lista.Add(Info);
                   }

               }

               return lista;

           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);

           }
       }

    }
}
