using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_proveedor_codigo_SRI_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje="";
        public List<cp_proveedor_codigo_SRI_Info> Get_List_proveedor_codigo_SRI(int empresa, decimal proveedor)
        {
            try
            {
                cp_proveedor_codigo_SRI_Data tp_data_ = new cp_proveedor_codigo_SRI_Data();
                return tp_data_.Get_List_proveedor_codigo_SRI(empresa, proveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_proveedor_codigo_SRI", ex.Message), ex) { EntityType = typeof(cp_proveedor_codigo_SRI_Bus) };
            }

        }

        public Boolean GrabarDB(cp_proveedor_codigo_SRI_Info info)
        {
            try
            {
                cp_proveedor_codigo_SRI_Data data = new cp_proveedor_codigo_SRI_Data();
                return data.GrabarDB(info);
            }
            catch(Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_codigo_SRI_Bus) };
            }
        }

        public Boolean GrabarDB(List<cp_proveedor_codigo_SRI_Info> lista)
        {
            try
            {
                cp_proveedor_codigo_SRI_Data data = new cp_proveedor_codigo_SRI_Data();
                return data.GrabarDB(lista);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_codigo_SRI_Bus) };
            }
        }



        public Boolean ModificarDB(cp_proveedor_codigo_SRI_Info info)
        {

            try
            {
                cp_proveedor_codigo_SRI_Data data = new cp_proveedor_codigo_SRI_Data();
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_codigo_SRI_Bus) };
            }
        }


        public Boolean ModificarLista(cp_proveedor_Info info)
        {
            try
            {
                    cp_proveedor_codigo_SRI_Data data = new cp_proveedor_codigo_SRI_Data();
                    data.ModificarDB(info);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarLista", ex.Message), ex) { EntityType = typeof(cp_proveedor_codigo_SRI_Bus) };
            }
        }


        public Boolean EliminarDB(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                cp_proveedor_codigo_SRI_Data data = new cp_proveedor_codigo_SRI_Data();
                return data.EliminarDB(IdEmpresa,  IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_codigo_SRI_Bus) };
            }
        
        
        }


    }
}
