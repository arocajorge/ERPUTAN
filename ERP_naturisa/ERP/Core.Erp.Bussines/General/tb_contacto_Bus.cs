using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.General
{
    public class tb_contacto_Bus
    {
        tb_contacto_Data data = new tb_contacto_Data();
        
        public List<tb_contacto_Info> Get_Contanto_x_cedula(int IdEmpresa, string Cedula)
        {
            List<tb_contacto_Info> Lista = new List<tb_contacto_Info>();
            try
            {
                Lista = data.Get_Contanto_x_cedula(IdEmpresa, Cedula);
                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get__Contacto_x Cedula", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }

        public bool ExisteContacto(int idEmpresa, decimal idContacto, decimal idPersona,ref string mensaje)
        {
            try
            {
                return data.ExisteContacto(idEmpresa, idContacto, idPersona, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCedula", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }

        public List<tb_contacto_Info> Get_List_Contacto(int IdEmpresa)
        {
            List<tb_contacto_Info> Lista = new List<tb_contacto_Info>();
            try
            {
                Lista = data.Get_List_Contacto(IdEmpresa);
                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Contacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }
        public int getId(int IdEmpresa)
        {
            try
            {
                return data.getId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }

        public bool GuardarContacto(tb_contacto_Info Info, decimal idContacto, ref string mensaje)
        {
            try
            {
                return data.GuardarContacto(Info, idContacto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarContacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }


        public Boolean ActualizarContacto(tb_contacto_Info Info, ref string mensaje)
        {
            try
            {
                return data.ActualizarContacto(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarContacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }

        public Boolean AnularContacto(tb_contacto_Info info, ref string msg)
        {
            Boolean resultado = false;
            try
            {
                resultado = data.AnularContacto(info, ref msg);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularContacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }

        }
        public tb_contacto_Info Get_Info_contacto(int IdEmpresa, decimal IdContacto, ref string mensaje)
        {            
            try
            {
                return data.Get_Info_contacto(IdEmpresa,IdContacto, ref mensaje);                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Información Contacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }


        public tb_contacto_Info Get_Info_contacto_x_Persona(int IdEmpresa,decimal IdPersona, ref string mensaje)
        {
            try
            {
                return data.Get_Info_contacto_x_Persona(IdEmpresa,IdPersona, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Información Contacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }


        public byte[] Get_Image_x_contacto(int IdEmpresa, decimal IdContacto, ref string mensaje)
        {
            try
            {
                return data.Get_Image_x_contacto(IdEmpresa, IdContacto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Información Contacto", ex.Message), ex) { EntityType = typeof(tb_contacto_Bus) };
            }
        }

    }
}
