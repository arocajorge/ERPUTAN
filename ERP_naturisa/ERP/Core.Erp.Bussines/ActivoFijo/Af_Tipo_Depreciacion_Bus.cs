using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Tipo_Depreciacion_Bus
    {
        Af_Tipo_Depreciacion_Data data = new Af_Tipo_Depreciacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<Af_Tipo_Depreciacion_Info> Get_List_ActivoFijo(int IdEmpresa)
        {                
            try
            {

                return data.Get_List_ActivoFijo(IdEmpresa);             
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Tipo_Depreciacion_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Tipo_Depreciacion_Info info, ref string msg)
        {
            try
            {                
                return data.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Tipo_Depreciacion_Bus) };
            }
        }


        public Boolean GrabarDB(Af_Tipo_Depreciacion_Info info, ref int id, ref string msg)
        {
            try
            {                
                return data.GrabarDB(info,ref id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Tipo_Depreciacion_Bus) };
            }
        }

        public Boolean AnularDB(Af_Tipo_Depreciacion_Info info, ref  string msg)
        {
            try
            {
                return data.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Tipo_Depreciacion_Bus) };
            }
        }

        public int Get_IdTipoDepre(string CodTipoDepreciacion)
        {
            try
            {
                return data.Get_IdTipoDepre(CodTipoDepreciacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Tipo_Depreciacion_Bus) };
            }
        }


        public Af_Tipo_Depreciacion_Bus() {
            
        }
    }
 }

