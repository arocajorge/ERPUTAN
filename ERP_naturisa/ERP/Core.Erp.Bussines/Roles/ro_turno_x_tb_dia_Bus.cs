using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_turno_x_tb_dia_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_turno_x_tb_dia_Data data = new ro_turno_x_tb_dia_Data();
        public List<ro_turno_x_tb_dia_Info> ConsultaDetallexTurno(int IdEmpresa, decimal IdTurno)
        {
            try
            {
                return data.Get_List_turno_x_tb_dia(IdEmpresa, IdTurno);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDetallexTurno", ex.Message), ex) { EntityType = typeof(ro_turno_x_tb_dia_Bus) };
            }            
        }

        public List<ro_turno_x_tb_dia_Info> ConsultaDetallexTurno(int IdEmpresa)
        {
            try
            {
                return data.Get_List_turno_x_tb_dia(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDetallexTurno", ex.Message), ex) { EntityType = typeof(ro_turno_x_tb_dia_Bus) };
            }
        }

        public Boolean GuardarDetalleTurno(List<ro_turno_x_tb_dia_Info> Lst, decimal Id, ref string mensaje)
        {
            try
            {
                return data.GuardarDetalleTurno(Lst,  Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetalleTurno", ex.Message), ex) { EntityType = typeof(ro_turno_x_tb_dia_Bus) };
            }

        }
      
    }
}
