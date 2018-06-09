using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Tipo_Prestamo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Tipo_Prestamo_Data odata = new ro_Tipo_Prestamo_Data();

        public Boolean GuardarDB(ro_Tipo_Prestamo_Info Info)
        {
            try
            {
                return odata.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }

        }

        public List<ro_Tipo_Prestamo_Info> ConsultaGeneral( int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Tipo_Prestamo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }

        }

        public ro_Tipo_Prestamo_Info ObtenerObjeto(int IdEmpresa, int IdTPrestamo)
        {
            try
            {
                return odata.Get_Info_Tipo_Prestamo(IdEmpresa, IdTPrestamo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }

        }

        public Boolean ModificarDB(ro_Tipo_Prestamo_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }

        }

        public Boolean AnularDB(ro_Tipo_Prestamo_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }

        }

        public int getId(int IdEmpresa)
        {
            try
            {
                ro_Tipo_Prestamo_Data data = new ro_Tipo_Prestamo_Data();
                return data.getId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }
        }

        public int getOrden(int IdEmpresa)
        {
            try
            {
                ro_Tipo_Prestamo_Data data = new ro_Tipo_Prestamo_Data();
                return data.getOrden(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getOrden", ex.Message), ex) { EntityType = typeof(ro_Tipo_Prestamo_Bus) };
            }
        }

       

    }
}
