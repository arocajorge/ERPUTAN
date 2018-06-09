/*CLASE: ro_DocumentoxEmp_Bus
 *MODIFICADA POR: ALBERTO MENA
 *FECHA: 24-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data .Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_DocumentoxEmp_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_DocumentoxEmp_Data oData = new ro_DocumentoxEmp_Data();
        string msg = "";


       



        public Boolean GuardarDB(List<ro_DocumentoxEmp_Info> LstInfo)
        {
            try
            {
              
                ro_DocumentoxEmp_Info info = new ro_DocumentoxEmp_Info();
                info = LstInfo.FirstOrDefault();
                if (EliminarDB(LstInfo, ref msg))
                {

                    return oData.GuardarDB(LstInfo);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_DocumentoxEmp_Bus) };

            }
        }

        public List<ro_DocumentoxEmp_Info> ConsultaXEmpleado(int idempresa, decimal idempleado)
        {
            try
            {
                return oData.ConsultaXEmpleado(idempresa, idempleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaXEmpleado", ex.Message), ex) { EntityType = typeof(ro_DocumentoxEmp_Bus) };

            }
        
        }


        public Boolean AnularDB(ro_DocumentoxEmp_Info Info, ref string msg)
        {
            try
            {
                return oData.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_DocumentoxEmp_Bus) };

            }
        }

        public Boolean EliminarDB(List< ro_DocumentoxEmp_Info> Info, ref string msg)
        {
            try
            {
                return oData.EliminarDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_DocumentoxEmp_Bus) };

            }
        }
    }
}
