using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_Sucursal_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Data data = new tb_Sucursal_Data();

        public string Get_Cod_Establecimiento_x_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return data.Get_Cod_Establecimiento_x_Sucursal(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };

            }
        }

        public tb_Sucursal_Info Get_Info_Sucursal(int idempresa, int IdSucursal)
        {
            try
            {
                return data.Get_Info_Sucursal(idempresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }
        }

        public List<tb_Sucursal_Info> Get_List_Sucursal(int idempresa)
        {
            try
            {
                List<tb_Sucursal_Info> lM = new List<tb_Sucursal_Info>();
                lM = data.Get_List_Sucursal(idempresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }
        }

        public List<tb_Sucursal_Info> Get_List_Sucursal_Todos(int IdEmpresa)
        {
            try
            {
                List<tb_Sucursal_Info> lM = new List<tb_Sucursal_Info>();
                lM = data.Get_List_Sucursal(IdEmpresa);
                lM.Add(new tb_Sucursal_Info(IdEmpresa, 0, "TODOS"));
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }
        }

        public int Get_numEstablecimiento_x_empresa_SRI(int IdEmpresa)
        {
            try
            {

                return data.Get_numEstablecimiento_x_empresa_SRI(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_numEstablecimiento_x_empresa_SRI", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };

            }
        }

        public Boolean ModificarDB(tb_Sucursal_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }
        }

        public int GetId(int idempresa)
        {
            try
            {
                  return data.GetId(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }

        }

        public Boolean GrabarDB(tb_Sucursal_Info info, ref int id, ref string msg)
        {
            try
            {
                return data.GrabarDB(info,ref id,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }
        }

        public Boolean EliminarDB(tb_Sucursal_Info info, ref  string msg)
        {
            try
            {
               
                return data.EliminarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }
        }

        public Boolean ValidarCodigoExiste(int IdEmresa, string Ruc, string Cod)
        {
            try
            {
               return data.ValidarCodigoExiste(IdEmresa, Ruc, Cod);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(tb_Sucursal_Bus) };
           
            }

        }
       
        public tb_Sucursal_Bus() {
            
        }
    }
}


