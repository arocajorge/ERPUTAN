using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Bancos
{
    public class vwba_Estado_cbte_ban_Bus
    {
        vwba_Estado_cbte_ban_Data oData = new vwba_Estado_cbte_ban_Data();

        public List<vwba_Estado_cbte_ban_Info> Get_Lista_Estado_cbte_ban()
        {
            try
            {
                return oData.Get_Lista_Estado_cbte_ban();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Estado_cbte_ban", ex.Message), ex) { EntityType = typeof(vwba_Estado_cbte_ban_Bus) };
            }
        }

        public List<vwba_Estado_cbte_ban_Info> Get_Lista_Estado_cbte_ban_Todos()
        {
            try
            {
                return oData.Get_Lista_Estado_cbte_ban_Todos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Estado_cbte_ban", ex.Message), ex) { EntityType = typeof(vwba_Estado_cbte_ban_Bus) };
            }
        }

    }
}
