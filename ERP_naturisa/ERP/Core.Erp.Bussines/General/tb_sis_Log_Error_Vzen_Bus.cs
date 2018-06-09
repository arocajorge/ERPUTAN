using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_Log_Error_Vzen_Bus
    {

        tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public void Log_Error(string msg)
        {
            try
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(msg, "", arreglo, "",
                    "", param.IdUsuario, param.ip, param.nom_pc, param.Fecha_Transac);
                string mensaje = "";


                oData.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, msg);

            
            }
            catch (Exception ex)
            {
                
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Log_Error", ex.Message), ex) { EntityType = typeof(tb_sis_Log_Error_Vzen_Bus) };
         
            }
        }


        public List<tb_sis_Log_Error_Vzen_Info> ObtenerLista_logError()
        {
            try
            {
                return oData.Get_List_Log_Error_Vzen();
            }
            catch (Exception ex)
            {
                return new List<tb_sis_Log_Error_Vzen_Info>();                
            }
        }

        public tb_sis_Log_Error_Vzen_Bus()
        {

        }
    }
}
