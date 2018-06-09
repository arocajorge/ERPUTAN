using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Bancos;

namespace Core.Erp.Business.Contabilidad
{
    
    public class ct_Cbtecble_det_Bus
    {
        
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<ct_Cbtecble_det_Info> Get_list_Cbtecble_det(int IdEmpresa,ref string MensajeError)
        {
            List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
            ct_Cbtecble_det_Data data = new ct_Cbtecble_det_Data();


            try
            {
                lm = data.Get_list_Cbtecble_det(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_det", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public List<ct_Cbtecble_det_Info> Get_list_Cbtecble_det(int IdEmpresa,int idTipoCbte, decimal id,ref string MensajeError)
        {
            List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
            ct_Cbtecble_det_Data data = new ct_Cbtecble_det_Data();


            try
            {
                lm = data.Get_list_Cbtecble_det(IdEmpresa, idTipoCbte, id, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_det", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Cbtecble_det_Info _CbteCble_det_Info,ref string MensajeError)
        {

            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                return _CbteCbleData.ModificarDB(_CbteCble_det_Info, ref MensajeError);
            }
            catch(Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }

        }

        public Boolean AnularDB(ct_Cbtecble_det_Info _CbteCble_det_Info,ref string MensajeError)
        {
            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                return _CbteCbleData.EliminarDB(_CbteCble_det_Info, ref MensajeError);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Cbtecble_det_Info _CbteCble_det_Info,ref string MensajeError)
        {
            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                return _CbteCbleData.GrabarDB(_CbteCble_det_Info,ref MensajeError);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public void Get_SaldoContableMesAnterior(int IdEmpresa, string IdCtaCble, DateTime Fecha, ref decimal  Saldo,ref string MensajeError)
        {
            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                _CbteCbleData.Get_SaldoContableMesAnterior(IdEmpresa,IdCtaCble, Fecha, ref Saldo,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_SaldoContableMesAnterior", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public List<vwct_cbtecble_Con_Saldo_Info> Get_list_Cbtecble_Con_Saldo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string MensajeError)
        {
            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                return _CbteCbleData.Get_list_Cbtecble_Con_Saldo(IdEmpresa, FechaIni, FechaFin,ref MensajeError);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_Con_Saldo", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public List<vwct_cbtecble_Con_Saldo_Info> Get_list_Cbtecble_OG_otrosPagos(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                return _CbteCbleData.Get_list_ObtenerCbtecble_OG_otrosPagos(IdEmpresa, IdCbteCble, IdTipoCbte,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_ObtenerCbtecble_OG_otrosPagos", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public List<ct_Cbtecble_det_Info> Get_list_CbteCble_x_cp_Conciliacion_caja(int IdEmpresa, decimal IdConciliacion_caja)
        {
            try
            {
                ct_Cbtecble_det_Data _CbteCbleData = new ct_Cbtecble_det_Data();
                return _CbteCbleData.Get_list_CbteCble_x_cp_Conciliacion_caja(IdEmpresa, IdConciliacion_caja);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_CbteCble_x_cp_Conciliacion_caja", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_det_Bus) };
            }
        }

        public ct_Cbtecble_det_Bus()
        {
           
        }

       
    }
}
