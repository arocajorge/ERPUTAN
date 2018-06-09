using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
   public class tb_sis_Impuesto_Tipo_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_Impuesto_Tipo_Data oData = new tb_sis_Impuesto_Tipo_Data();



        public List<tb_sis_Impuesto_Tipo_Info> Get_List_impuesto()
        {
            try
            {

                return oData.Get_List_impuesto();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public tb_sis_Impuesto_Tipo_Info Get_Info_impuesto(string IdTipoImpuesto)
        {
            try
            {
                return oData.Get_Info_impuesto(IdTipoImpuesto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

    }
}
