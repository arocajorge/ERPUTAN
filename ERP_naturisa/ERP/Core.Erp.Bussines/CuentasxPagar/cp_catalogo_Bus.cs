using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_catalogo_Bus
    {
        cp_catalogo_Data oData = new cp_catalogo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<cp_catalogo_Info> Get_List_catalogo(string IdCatalogo_tipo)
        {
            try
            {
                return oData.Get_List_catalogo(IdCatalogo_tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_catalogo", ex.Message), ex) { EntityType = typeof(cp_catalogo_Bus) };
            }
        
        }
    }
}
