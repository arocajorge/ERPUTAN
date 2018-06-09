using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_archivos_para_banco_x_cxp_Bus
    {
      cp_archivos_para_banco_x_cxp_Data data = new cp_archivos_para_banco_x_cxp_Data();
        public Boolean GuardaDB(cp_archivos_para_banco_x_cxp_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
               data.GuardaDB(Item,ref Id,ref mensaje);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardaDB", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_Bus) };
            }
        }

        public Boolean ModificarDB(cp_archivos_para_banco_x_cxp_Info Info, ref string msg)
        {
            try
            {

                return data.ModificarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_Bus) };
            }
        }

        public Boolean AnularDB(cp_archivos_para_banco_x_cxp_Info Info)
        {
            try
            {
                return data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_Bus) };
            }
        }

        public List<cp_archivos_para_banco_x_cxp_Info> Get_List_Pagos_x_Archivos(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {

                return data.Get_List_Pagos_x_Archivos(IdEmpresa, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_Bus) };
            }
        }

    }
}
