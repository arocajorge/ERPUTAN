using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Business.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_Documento_Tipo_x_Empresa_Data data = new tb_sis_Documento_Tipo_x_Empresa_Data();
        public List<tb_sis_Documento_Tipo_x_Empresa_Info> Get_List_sis_Documento_Tipo_x_Empresa(int IdEmpresa)
        {
            try
            {
                return data.Get_List_sis_Documento_Tipo_x_Empresa(IdEmpresa); ;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPorEmpresa", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         

            }
        }

        public Boolean GuardarDB(List<tb_sis_Documento_Tipo_x_Empresa_Info> lst)
        {
            try
            {
                return data.GuardarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarListaCompleta", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         
            }

        }


        public Boolean GuardarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
                return data.GuardarDB(Info); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         
            }

        }

        public Boolean ValidarSiExiste(string codDocumentoTipo,int IdEmpresa)
        {
            try
            {
                return data.ValidarSiExiste(codDocumentoTipo,IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         
            }

        }


        public Boolean EliminarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
                return data.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         
            }

        }

        public Boolean EliminarDB(List<tb_sis_Documento_Tipo_x_Empresa_Info> lst)
        {
            try
            {
                return data.EliminarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         
            }
        }

        public Boolean ModificarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
              return  data.ModificarDB(Info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Bus) };
         
                
            }
           
        }

        
    }
}
