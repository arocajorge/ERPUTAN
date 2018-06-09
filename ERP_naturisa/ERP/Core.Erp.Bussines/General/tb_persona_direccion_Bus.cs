using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
   public class tb_persona_direccion_Bus
    {

        string mensaje = "";
        tb_persona_direccion_Data Odata = new tb_persona_direccion_Data();

        public int GetId(decimal IdPersona)
        {
            try
            {
                return Odata.GetId(IdPersona);
            }
            catch (Exception ex)
            {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(tb_persona_direccion_Bus) };
            }
        }

        public Boolean GuardarDB(tb_persona_direccion_Info Info, ref int IdDireccion, ref string msjError)
        {
            try
            {
                return Odata.GuardarDB(Info, ref IdDireccion, ref msjError);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean ModificarDB(tb_persona_direccion_Info Info, ref string msjError)
        {
            try
            {
                return Odata.ModificarDB(Info, ref msjError);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean ModificarDB(List<tb_persona_direccion_Info> ListInfo, ref string msjError)
        {
            try
            {
                return Odata.ModificarDB(ListInfo, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean AnularDB(decimal IdPersona, int IdDireccion, ref string msjError)
        {
            try
            {
                return Odata.AnularDB(IdPersona, IdDireccion, ref msjError);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public List<tb_persona_direccion_Info> Get_List_persona_direccion(decimal IdPersona)
        {
            try
            {
                return Odata.Get_List_persona_direccion(IdPersona);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public tb_persona_direccion_Info Get_Info_persona_direccion(decimal IdPersona, int IdDireccion)
        {
            try
            {
                return Odata.Get_Info_persona_direccion(IdPersona, IdDireccion);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean GuardarDB(tb_persona_direccion_Info Info, decimal IdPersona, ref string msjError)
        {
            try
            {
                return Odata.GuardarDB(Info, IdPersona, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean GuardarDB(List<tb_persona_direccion_Info> Lista, decimal IdPersona, ref string msg)
        {
            try
            {
                return Odata.GuardarDB(Lista, IdPersona, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean EliminarDB(decimal IdPersona, ref string mensaje)
        {
            try
            {
                return Odata.Eliminar(IdPersona, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }
    }
}
