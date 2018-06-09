using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General; 

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_codigo_SRI_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI_x_codigo(string[] CodRetencion, int IdEmpresa)
        {
            try
            {
                cp_codigo_SRI_Data tp_data_ = new cp_codigo_SRI_Data();
                return tp_data_.Get_List_codigo_SRI_x_codigo(CodRetencion, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_codigo_SRI_x_codigo", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }

        }

       

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI(string cod_tipo)
        {
            try
            {
                cp_codigo_SRI_Data tp_data_ = new cp_codigo_SRI_Data();
                return tp_data_.Get_List_codigo_SRI(cod_tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_codigo_SRI", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }


        }

        public Boolean GrabarDB(cp_codigo_SRI_Info info, ref int id)
        {
            try
            {
                cp_codigo_SRI_Data data = new cp_codigo_SRI_Data();
                return data.GrabarDB(info, ref id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }
        }

        public Boolean ModificarDB(cp_codigo_SRI_Info info)
        {

            try
            {
                cp_codigo_SRI_Data data = new cp_codigo_SRI_Data();
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }
        }

        public Boolean ModificarDB(List<cp_codigo_SRI_x_CtaCble_Info> lista, int codigoSRI)
        {

            try
            {
                cp_codigo_SRI_Data data = new cp_codigo_SRI_Data();
                return data.ModificarDB(lista, codigoSRI);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }
        }

        public Boolean AnularDB(cp_codigo_SRI_Info info)
        {
            try
            {
                cp_codigo_SRI_Data data = new cp_codigo_SRI_Data();
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }
        }

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI_(int IdEmpresa)
        {
            try
            {
                cp_codigo_SRI_Data tp_data_ = new cp_codigo_SRI_Data();
                return tp_data_.Get_List_codigo_SRI_(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_codigo_SRI_", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }

        }

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI_IvaRet(int IdEmpresa)
        {
            try
            {
                 cp_codigo_SRI_Data tp_data_ = new cp_codigo_SRI_Data();
                 return tp_data_.Get_List_codigo_SRI_IvaRet(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_codigo_SRI_IvaRet", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_Bus) };
            }
        }


        public cp_codigo_SRI_Bus()
        {
           
        }
    }
}
