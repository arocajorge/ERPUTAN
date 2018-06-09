using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_ConfRubrosAcumulados_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_ConfRubrosAcumulado_Data oData = new ro_ConfRubrosAcumulado_Data();

        public List<ro_ConfRubrosAcumulado_Info> ConsultaGeneral(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                return oData.ConsultaGeneral(IdEmpresa,IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_ConfRubrosAcumulados_Bus) };


            }

        }



        public List<ro_ConfRubrosAcumulado_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                return oData.ConsultaGeneral(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_ConfRubrosAcumulados_Bus) };


            }

        }




        
        public Boolean GrabarDB(ro_ConfRubrosAcumulado_Info prI, ref string mensaje)
        {
            try
            {
                return oData.GrabarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_ConfRubrosAcumulados_Bus) };

            }
        }

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_ConfRubrosAcumulados_Bus) };

            }
        }

        public Boolean ExisteRubro(int IdEmpresa, string Idrubro)
        {
            try
            {
                ro_ConfRubrosAcumulado_Data data = new ro_ConfRubrosAcumulado_Data();
                return data.ExisteRubro(IdEmpresa, Idrubro);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteRubro", ex.Message), ex) { EntityType = typeof(ro_ConfRubrosAcumulados_Bus) };

            }

        }


         public ro_ConfRubrosAcumulado_Info GetConsultaPorId(int idEmpresa, string idRubro)
         {
             try{
                     return oData.GetConsultaPorId(idEmpresa,idRubro);
                 }catch (Exception ex){
                     Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                     throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetConsultaPorId", ex.Message), ex) { EntityType = typeof(ro_ConfRubrosAcumulados_Bus) };

                 }
        }



    }
}
