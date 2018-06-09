using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_Periodo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Periodo_Data data = new ct_Periodo_Data();

        public List<ct_Periodo_Info> Get_List_Periodo(int IdEmpresa,ref string MensajeError)
        {
            List<ct_Periodo_Info> lm = new List<ct_Periodo_Info>();


            try
            {
                lm = data.Get_List_Periodo(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public List<ct_Periodo_Info> Get_List_PeriodoCombo(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Periodo_Info> lm = new List<ct_Periodo_Info>();
            try
            {
                lm = data.Get_List_Periodo(IdEmpresa,ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }


        public ct_Periodo_Info Get_Info_Periodo(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {
                return data.Get_Info_Periodo(IdEmpresa, IdPeriodo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
                
            }
        }

        public Boolean ModificarDB(ct_Periodo_Info info, ref string MensajeError)
        {
            try
            {
                return data.ModificarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public Boolean Modificar_Estado_CierreDB(int IdEmpresa, int IdPeriodo, string SCerrado,ref string MensajeError)
        {
            try
            {
                return data.Modificar_Estado_CierreDB(IdEmpresa, IdPeriodo, SCerrado, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_CierreDB", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public Boolean EliminarDB(ct_Periodo_Info info, ref string MensajeError)
        {
            try
            {
                return data.EliminarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Periodo_Info info, ref string MensajeError)
        {
            try
            {
                return data.GrabarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public ct_Periodo_Info Get_Info_Periodo(int IdEmpresa, DateTime fecha, ref string MensajeError)
        {
            try
            {

                return data.Get_Info_Periodo( IdEmpresa, fecha,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
            
        }

        public ct_Periodo_Info Get_Info_Ultimo_periodo_mayorizado(int IdEmpresa, ref string MensajeError)
        {
            try
            {
 
                return data.Get_Info_Ultimo_periodo_mayorizado(IdEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Ultimo_periodo_mayorizado", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };

                
            }
        }

        public Boolean Get_Periodo_Esta_Cerrado(int idempresa, DateTime fecha, ref string MensajeError)
        {
            try
            {
                        return data.Periodo_Esta_Cerrado(idempresa, fecha, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Periodo_Esta_Cerrado", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public ct_Periodo_Info Get_Info_PeriodoAnterior(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {
                return data.Get_Info_PeriodoAnterior(IdEmpresa, IdPeriodo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_PeriodoAnterior", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }

        }

        public ct_Periodo_Bus()
        {
            
        }
    }
}
