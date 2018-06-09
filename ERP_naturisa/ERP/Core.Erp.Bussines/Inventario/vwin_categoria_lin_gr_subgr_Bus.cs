using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
   public class vwin_categoria_lin_gr_subgr_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwin_categoria_lin_gr_subgr_Data oData = new vwin_categoria_lin_gr_subgr_Data();

        public List<vwin_categoria_lin_gr_subgr_Info> Get_List_in_categoria_lin_gr_subg(int IdEmpresa)
       {
           try
           {
               return oData.Get_List_in_categoria_lin_gr_subgr(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_lin_gr_subgr", ex.Message), ex) { EntityType = typeof(vwin_categoria_lin_gr_subgr_Bus) };

             
           }

       }


    }
}
