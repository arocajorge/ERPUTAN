using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data .Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class vwBA_Sucursal_x_TipoCobro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwBA_Sucursal_x_TipoCobro_Data data = new vwBA_Sucursal_x_TipoCobro_Data();
        public List<vwBA_Sucursal_x_TipoCobro_Info> Get_List_vwBA_Sucursal_x_TipoCobro(int IdEmpresa)
        {
            try
            {
                 return data.Get_List_vwBA_Sucursal_x_TipoCobro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_vwBA_Sucursal_x_TipoCobro", ex.Message), ex) { EntityType = typeof(vwBA_Sucursal_x_TipoCobro_Bus) };
            }

        }
    }
}
