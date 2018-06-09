using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;


namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Activo_fijo_tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Af_Activo_fijo_tipo_Data data = new Af_Activo_fijo_tipo_Data();
        string mensaje = "";

        public List<Af_Activo_fijo_tipo_Info> Get_List_ActivoFijoTipo(int IdEmpresa)
        {
                List<Af_Activo_fijo_tipo_Info> lM = new List<Af_Activo_fijo_tipo_Info>();                
            try
            {

                lM = data.Get_List_ActivoFijoTipo(IdEmpresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijoTipo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_tipo_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Activo_fijo_tipo_Info info, ref string msg)
        {

            try
            {                
                return data.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_tipo_Bus) };
            }
        }
        
        public Boolean GrabarDB(Af_Activo_fijo_tipo_Info info, ref int id, ref string msg)
        {
            try
            {                
                return data.GrabarDB(info, ref id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_tipo_Bus) };
            }
        }

        public Boolean EliminarDB(Af_Activo_fijo_tipo_Info info, ref  string msg)
        {
            try
            {                
                return data.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_tipo_Bus) };
            }
        }

       
    }
}
