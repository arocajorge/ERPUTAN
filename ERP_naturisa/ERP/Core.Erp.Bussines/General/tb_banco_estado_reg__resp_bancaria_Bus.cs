using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.General
{
    public class tb_banco_estado_reg__resp_bancaria_Bus
    {
        tb_banco_estado_reg__resp_bancaria_Data oData = new tb_banco_estado_reg__resp_bancaria_Data();

        public List<tb_banco_estado_reg__resp_bancaria_Info> Get_Lista_Estados()
        {
            try
            {
                return oData.Get_Lista_Estados();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Estados", ex.Message), ex) { EntityType = typeof(tb_banco_estado_reg__resp_bancaria_Bus) };

            }
        }
    }
}
