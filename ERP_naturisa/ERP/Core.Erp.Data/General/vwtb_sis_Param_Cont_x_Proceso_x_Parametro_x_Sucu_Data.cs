using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
    public class vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Data
    {
        string mensaje = "";
        public List<vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Get_List_tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu(int IdEmpresa, string IdProcesoConta)
        {
            try 
	        {
                
                return new List<vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();

	        }
	        catch (Exception ex)
	        {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
