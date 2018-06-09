using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Roles_Fj
{
   public class ro_descuento_no_planificados_Det_Bus
   {
       ro_descuento_no_planificados_Det_Data data = new ro_descuento_no_planificados_Det_Data();
       string mensaje = "";
       public bool Guardar_DB(List<ro_descuento_no_planificados_Det_Info> lista)
       {
           try
           {
               return data.Guardar_DB(lista);
           }
           catch (Exception ex)
           {

               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }



       public List<ro_descuento_no_planificados_Det_Info> listado_Descuento(int IdEmpresa, int IdNomina_Tipo, decimal IdEmpleado, int IdDescuento)
       {
           try
           {
               return data.listado_Descuento(IdEmpresa, IdNomina_Tipo, IdEmpleado, IdDescuento);

           }
           catch (Exception ex)
           {
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
              
           }
       }

    }
}
