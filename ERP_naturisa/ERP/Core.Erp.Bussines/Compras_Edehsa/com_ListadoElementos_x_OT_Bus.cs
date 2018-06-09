using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras_Edehsa
{
    public class com_ListadoElementos_x_OT_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_ListadoElementos_x_OT_Data Data = new com_ListadoElementos_x_OT_Data();

        public Boolean GrabarDB(com_ListadoElementos_x_OT_Info info, ref int id, ref string msg)
        {
            try
            {
                return Data.GrabarDB(info, ref id, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Bus) };
            }
        }

        public List<com_ListadoElementos_x_OT_Info> Get_List_ListadoElementos_x_OT(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_ListadoElementos_x_OT(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoElementos_x_OT", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Bus) };
            }
        }

        public Boolean AnularDB(com_ListadoElementos_x_OT_Info Info, ref string msg)
        {
            try
            {
                return Data.AnularDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Bus) };
            }
        }


        public com_ListadoElementos_x_OT_Info Get_Info_ListadoElementos_x_OT(int IdEmpresa, decimal IdLstMater)
        {
            try
            {
                return Data.Get_Info_ListadoElementos_x_OT(IdEmpresa, IdLstMater);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ListadoElementos_x_OT", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Bus) };
            }
        }

        public Boolean ModificarDB(com_ListadoElementos_x_OT_Info info, ref string msg)
        {
            try
            {
                return Data.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Bus) };
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMateriales_Det", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Bus) };
            }
        }
    }
}
