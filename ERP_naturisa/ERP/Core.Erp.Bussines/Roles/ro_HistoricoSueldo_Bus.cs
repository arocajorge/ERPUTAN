using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_HistoricoSueldo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_HistoricoSueldo_Data oData = new ro_HistoricoSueldo_Data();

        public Boolean GrabarDB(ro_HistoricoSueldo_Info prI, ref string mensaje)
        {
            try
            {
                return oData.GrabarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_HistoricoSueldo_Bus) };
            }
        }

        public List<ro_HistoricoSueldo_Info> Get_List_HistoricoSueldo(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_List_HistoricoSueldo(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_HistoricoSueldo_Bus) };
            }

        }

        
        public List<ro_HistoricoSueldo_Info> Get_List_HistoricoSueldo(int idEmpresa, decimal idEmpleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_List_HistoricoSueldo(idEmpresa, idEmpleado, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_HistoricoSueldo_Bus) };
            }

        }




    public double GetSueldoActual(int idEmpresa, decimal idEmpleado)
    {
        try
            {
                double valorRetornar=0;

                List<ro_HistoricoSueldo_Info> oListRo_HistoricoSueldo_Info = new List<ro_HistoricoSueldo_Info>();
                valorRetornar = (from a in oData.Get_List_HistoricoSueldo(idEmpresa, idEmpleado)
                                select a.SueldoActual).FirstOrDefault();

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetSueldoActual", ex.Message), ex) { EntityType = typeof(ro_HistoricoSueldo_Bus) };
            }

    
    
    }


    public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
    {
        try
        {
            return oData.EliminarBD(idEmpresa, idEmpleado, ref msg);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_HistoricoSueldo_Bus) };
        }

    }


    public double Get_sueldo_actual(int IdEmpresa, decimal IdEmpleado)
    {
            try
            {
                return oData.Get_sueldo_actual(IdEmpresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_HistoricoSueldo_Bus) };
            }

        }


    }
}
