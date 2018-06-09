using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.SeguridadAcceso;

namespace Core.Erp.Business.SeguridadAcceso
{
    public class seg_Menu_bus
    {
        public List<seg_Menu_info> Get_List_Menu(ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.Get_List_Menu(ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.Get_List_Menu_x_Empresa(idEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu_x_Empresa", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa_x_Usuario(string idUsuario, int idEmpresa, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.Get_List_Menu_x_Empresa_x_Usuario(idUsuario, idEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu_x_Empresa_x_Usuario", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public seg_Menu_info Get_Info_Menu(int idmenu, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.Get_Info_Menu(idmenu, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean ModificarDB(seg_Menu_info info, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.ModificarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean ModificarDB(List<seg_Menu_info> lista, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.ModificarDB(lista, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public int getIdMenu_Max(ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.getIdMenu_Max(ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getIdMenu_Max", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean GrabarDB(seg_Menu_info info, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.GrabarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean EliminarDB(List<seg_Menu_info> Lista, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.EliminarDB(Lista, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean EliminarDB(seg_Menu_info info, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                return data.EliminarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean ExisteRelacionMenu(int idMenu, ref string MensajeError)
        {
            try
            {
                Boolean existe = false;
                seg_Menu_data data = new seg_Menu_data();
                existe = data.ExisteRelacionMenu(idMenu, ref MensajeError);
                return existe;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteRelacionMenu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public Boolean Anular_Menu(int idMenu, ref string MensajeError)
        {
            try
            {
                seg_Menu_data data = new seg_Menu_data();
                data.Anular(idMenu, ref MensajeError);
                if (MensajeError != "")
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }
    }
}
