
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Acta_Finiquito_Detalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        
        ro_Acta_Finiquito_Detalle_Data odata = new ro_Acta_Finiquito_Detalle_Data();


        public List<ro_Acta_Finiquito_Detalle_Info> GetListConsultaPorId(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito)
        {
            try
            {
                return odata.GetListConsultaPorId(idEmpresa,idEmpleado,idActaFiniquito);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorId", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Detalle_Bus) };

            }
        }


        public Boolean GrabarBD(ro_Acta_Finiquito_Detalle_Info info,  ref string msg) {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA
               
                    info.IdUsuario = param.IdUsuario;
                    info.Fecha_Transac = param.Fecha_Transac;
                    valorRetornar = odata.GrabarBD(info, ref msg);                
                

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Detalle_Bus) };

            }        
        }


        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito, ref string msg) 
        {
            try
            {
                return odata.EliminarBD(idEmpresa, idEmpleado, idActaFiniquito, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Acta_Finiquito_Detalle_Bus) };

            }
        
        }
   






    }
}
