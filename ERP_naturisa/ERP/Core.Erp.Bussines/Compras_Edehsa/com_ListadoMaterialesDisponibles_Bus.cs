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
    public class com_ListadoMaterialesDisponibles_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_ListadoMaterialesDisponibles_Data Data = new com_ListadoMaterialesDisponibles_Data();

        public Boolean GrabarDB(com_ListadoMaterialesDisponibles_Info info, ref int id, ref string msg)
        {
            try
            {
                return Data.GrabarDB(info, ref id, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_Bus) };
            }
        }

        public List<com_ListadoMaterialesDisponibles_Info> Get_List_ListadoMaterialesDisponibles(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_ListadoMaterialesDisponibles(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_Bus) };
            }
        }

        public Boolean AnularDB(com_ListadoMaterialesDisponibles_Info Info, ref string msg)
        {
            try
            {
                return Data.AnularDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_Bus) };
            }
        }


        public com_ListadoMaterialesDisponibles_Info Get_Info_ListadoMaterialesDisponibles(int IdEmpresa, decimal IdLstMater)
        {
            try
            {
                return Data.Get_Info_ListadoMaterialesDisponibles(IdEmpresa, IdLstMater);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ListadoMaterialesDisponibles", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_Bus) };
            }
        }

        public Boolean ModificarDB(com_ListadoMaterialesDisponibles_Info info, ref string msg)
        {
            try
            {
                return Data.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_Bus) };
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_Bus) };
            }
        }
    }
}
