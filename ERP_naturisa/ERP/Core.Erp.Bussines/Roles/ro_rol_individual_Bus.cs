/*CLASE: ro_rol_individual_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 04-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;

namespace Core.Erp.Business.Roles
{
    public class ro_rol_individual_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_rol_individual_Data oData = new ro_rol_individual_Data();

        public List<ro_rol_individual_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {

            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_rol_individual_Bus) };
            }
        }



        public Boolean GuardarBD(ro_rol_individual_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA DETALLE
                if (oData.GetExiste(info, ref mensaje))
                {
                    valorRetornar = oData.ModificarBD(info, ref mensaje);
                }
                else
                {//ACTUALIZA DETALLE
                    valorRetornar = oData.GuardarBD(info, ref mensaje);
                }
                return valorRetornar;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_rol_individual_Bus) };
            }
        }



        public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg)
        { 
        try{

            return oData.EliminarBD(idEmpresa,idNomina,idNominaLiqui,idPeriodo,idEmpleado,ref msg);

        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_rol_individual_Bus) };
        }
        
        
        }









    }
}
