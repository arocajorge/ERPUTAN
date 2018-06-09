using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_estado_cierre_Bus
    {
        #region
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_estado_cierre_Data Odata = new com_estado_cierre_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public List<com_estado_cierre_Info> Get_List_estado_cierre()
        {
            try
            {

                return Odata.Get_List_estado_cierre();

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_estado_cierre", ex.Message), ex) { EntityType = typeof(com_estado_cierre_Bus) };
            }
        }

        public Boolean GrabarDB(com_estado_cierre_Info Info, ref string msg)
        {
            try
            {
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.Fecha_Transac = param.GetDateServer();

                return Odata.GrabarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_estado_cierre_Bus) };
            }
        }

        public Boolean ModificarDB(com_estado_cierre_Info Info, ref string msg)
        {

            try
            {
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                return Odata.ModificarDB(Info, ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_estado_cierre_Bus) };
            }
        }

        public Boolean AnularDB(com_estado_cierre_Info Info, ref string msg)
        {
            try
            {                
                Info.IdUsuarioUltAnu = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                Info.FechaHoraAnul = param.GetDateServer();

                return Odata.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_estado_cierre_Bus) };
            }
                    
        }

 
    }
}
