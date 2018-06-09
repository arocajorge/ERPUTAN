using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_Balance_x_General_x_Usuario_Data
    {
        string mensaje = "";
        


        public Boolean Start_spCON_Obtener_BalanceGeneral(int IdEmpresa, DateTime i_FechaIni, DateTime i_FechaFin, string i_usuario, string i_pc)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public List<ct_Balance_x_General_x_Usuario_Info> ObtenerDatos_Reporte_Standar(int IdEmpresa, string i_usuario, string i_pc, int i_Nivel, List<ct_Plancta_nivel_Info> niveles)
        {

            try
            {
                List<ct_Balance_x_General_x_Usuario_Info> lM = new List<ct_Balance_x_General_x_Usuario_Info>();

                
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ct_Balance_x_General_x_Usuario_Info> ObtenerDatos_Reporte_SL_Anterior(int IdEmpresa, string i_usuario, string i_pc, int i_Nivel, List<ct_Plancta_nivel_Info> niveles)
        {

            try
            {
                List<ct_Balance_x_General_x_Usuario_Info> lM = new List<ct_Balance_x_General_x_Usuario_Info>();
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
    }
}
