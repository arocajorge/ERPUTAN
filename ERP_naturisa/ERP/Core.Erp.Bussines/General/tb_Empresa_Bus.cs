using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
  
    public class tb_Empresa_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        
        public tb_Empresa_Info Get_Info_Empresa(int IdEmpresa)
        {
            try
            {
                tb_Empresa_Data EmD = new tb_Empresa_Data();
                tb_Empresa_Info le = new tb_Empresa_Info();
                le = EmD.Get_Info_Empresa(IdEmpresa);
                return le;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public List<tb_Empresa_Info> Get_List_Empresa()
        {

            try
            {
                tb_Empresa_Data EmD = new tb_Empresa_Data();
                List<tb_Empresa_Info> le = new List<tb_Empresa_Info>();
                le = EmD.Get_List_Empresa();
                return le;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerlistEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
                   

            }

        }

        public List<tb_Empresa_Info> Get_List_Empresa(List<int> List_Empresa)
        {

            try
            {
                tb_Empresa_Data EmD = new tb_Empresa_Data();
                List<tb_Empresa_Info> le = new List<tb_Empresa_Info>();
                le = EmD.Get_List_Empresa(List_Empresa);
                return le;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerlistEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
           }
        }

          public  byte []  Get_Fondo_Pantalla_x_Empresa(int IdEmpresa)
        {

            try
            {
                tb_Empresa_Data EmD = new tb_Empresa_Data();
                return EmD.Get_Fondo_Pantalla_x_Empresa(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Fondo_Pantalla_x_Empresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }


        public List<tb_Empresa_Info> Get_List_Empresa_x_Usuario(string IdUsuario)
        {
            try
            {
                tb_Empresa_Data EmD = new tb_Empresa_Data();
                List<tb_Empresa_Info> le = new List<tb_Empresa_Info>();
                le = EmD.Get_List_Empresa_x_Usuario(IdUsuario);
                return le;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerlistEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }
       
        public Boolean ModificarDB(tb_Empresa_Info info)
        {
            try
            {
                tb_Empresa_Data epD = new tb_Empresa_Data();
              

                return epD.ModificarDB(info);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
                 
            }
        }

        public Boolean GrabarDB(tb_Empresa_Info info)
        {
            try
            {
                tb_Empresa_Data empD = new tb_Empresa_Data();

                return empD.GrabarDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
                 
            }
        
        }

    }
}
