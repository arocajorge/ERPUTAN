using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.Compras;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras_Edehsa
{
    public class com_ListadoDiseno_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_ListadoDiseno_Data Data = new com_ListadoDiseno_Data();

        public Boolean GrabarDB(com_ListadoDiseno_Info info, ref int id, ref string msg)
        {
            try
            {
                return Data.GrabarDB(info, ref id, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }

        public List<com_ListadoDiseno_Info> Get_List_ListadoDiseno(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_ListadoDiseno(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoDiseno", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }
        public List<com_ListadoDiseno_Info> Get_List_ListadoDisenoCMB(int IdEmpresa, int IdSucursal, string CodObra)
        {
            try
            {
                return Data.Get_List_ListadoDisenoCMB(IdEmpresa, IdSucursal, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoDiseno", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }
        public Boolean AnularDB(com_ListadoDiseno_Info Info, ref string msg)
        {
            try
            {
                return Data.AnularDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }


        public com_ListadoDiseno_Info Get_Info_ListadoDiseno(int IdEmpresa, decimal IdLstMater)
        {
            try
            {
                return Data.Get_Info_ListadoDiseno(IdEmpresa, IdLstMater);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ListadoDiseno", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }

        public Boolean ModificarDB(com_ListadoDiseno_Info info, ref string msg)
        {
            try
            {
                return Data.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }

        public int GetId(int IdEmpresa, ref string msg)
        {
            try
            {
                return Data.GetId(IdEmpresa, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoDiseno_Det", ex.Message), ex) { EntityType = typeof(com_ListadoDiseno_Bus) };
            }
        }

    }
}
