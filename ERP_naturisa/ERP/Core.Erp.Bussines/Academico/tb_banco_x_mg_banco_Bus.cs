using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class tb_banco_x_mg_banco_Bus
    {
        tb_banco_x_mg_banco_Data oData = new tb_banco_x_mg_banco_Data();
        public List<tb_banco_x_mg_banco_Info> Get_List_Banco_Aca()
        {
            try
            {
                return oData.Get_Listado_Banco_Aca();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Banco_Aca", ex.Message), ex) { EntityType = typeof(tb_banco_x_mg_banco_Bus) };
            }

        }
    }
}
